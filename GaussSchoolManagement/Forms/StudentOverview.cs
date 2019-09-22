﻿using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class StudentOverview : Form
    {
        public List<int> StudentIDs { get; set; }

        private int _id = -1;
        public int StudentID
        {
            get => _id;
            set
            {
                _id = value;
                FillTextFields();
            }
        }

        public StudentOverview()
        {
            InitializeComponent();
            UpdateStudentIds();
            StudentID = StudentIDs.Min();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EditStudentDetails(this);
            form.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new StudentsList(this);
            form.StudentsSelected += (s, args) =>
            {
                if (args.Count < 1)
                    return;

                StudentID = args[0];
            };
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditStudentDetails(this, true);
            form.Show();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!StudentIDs.Any() || StudentID <= StudentIDs.Min())
                return;

            DecrementStudentId();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!StudentIDs.Any() || StudentID >= StudentIDs.Max())
                return;

            IncrementStudentId();
        }

        private void FillTextFields()
        {
            if (StudentID <= 0 || !StudentIDs.Contains(StudentID))
                return;

            var data = DatabaseModel.Instance.Nxenes.First(x => x.NxenesId == StudentID);
            lblId.Text = StudentID.ToString();
            lblName.Text = data.Persona.Emri;
            lblSurname.Text = data.Persona.Mbiemri;

            PopulateCourseDataGrid();

            PopulatePaymentsDataGrid();


            UpdateButtonEnabled();
        }

        private void UpdateButtonEnabled()
        {
            if (StudentID == StudentIDs.Max())
                btnNext.Enabled = false;

            if (StudentID > StudentIDs.Min())
                btnPrevious.Enabled = true;

            if (StudentID == StudentIDs.Min())
                btnPrevious.Enabled = false;

            if (StudentID < StudentIDs.Max())
                btnNext.Enabled = true;
        }

        public void UpdateStudentIds()
        {
            StudentIDs =  DatabaseModel.Instance.Nxenes
                                .Select(x => x.NxenesId)
                                .AsEnumerable().ToList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!StudentIDs.Contains(StudentID))
                return;
            var student = DatabaseModel.Instance.Nxenes.First(x=>x.NxenesId == StudentID);
            DatabaseModel.Instance.Nxenes.Remove(student);
            DatabaseModel.Instance.SaveChanges();
            UpdateStudentIds();
            if (StudentIDs.Contains(StudentID + 1))
                IncrementStudentId();
            else
                DecrementStudentId();
            UpdateButtonEnabled();
        }

        private void IncrementStudentId()
        {
            var nextId = _id + 1;
            while (nextId < StudentIDs.Max() && !StudentIDs.Contains(nextId))
                nextId++;

            StudentID = nextId;
        }

        private void DecrementStudentId()
        {
            var previousId = _id - 1;
            while (previousId > StudentIDs.Min() && !StudentIDs.Contains(previousId))
                previousId--;
            StudentID = previousId;
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new CoursesList(this, true);
            form.CoursesSelected += (s, args) =>
            {
                if (args.Count < 1)
                    return;

                AddCoursesToStudent(args);
            };
            form.Show();
        }

        private void AddCoursesToStudent(List<int> StudentIds)
        {
            var newRegistrations = StudentIds.Select(x => new NxenesKurse { NxenesId = StudentID, KursId = x });
            DatabaseModel.Instance.NxenesKurses.AddRange(newRegistrations);
            DatabaseModel.Instance.SaveChanges();

            PopulateCourseDataGrid();

            MessageBox.Show($"Successfully added {StudentIds.Count} courses");
        }

        private void BtnRemoveCourse_Click(object sender, EventArgs e)
        {
            var courseId = (int)dtgCourses.CurrentRow.Cells[0].Value;
            var course = DatabaseModel.Instance.NxenesKurses.First(x => x.NxenesKursId == courseId);
            DatabaseModel.Instance.NxenesKurses.Remove(course);
            DatabaseModel.Instance.SaveChanges();

            PopulateCourseDataGrid();
        }

        private void PopulateCourseDataGrid()
        {
            var courses = DatabaseModel.Instance.NxenesKurses
                .Where(x => x.NxenesId == StudentID && x.Kurse != null)
                .Select(x =>
                new
                {
                    Id = x.NxenesKursId,
                    Name = x.Kurse.EmriKursit,
                    SchoolYear = x.Kurse.VitiShkollor,
                })
               .ToList();
            dtgCourses.DataSource = courses;
            foreach (DataGridViewColumn column in dtgCourses.Columns)
            {
                if (column.Name == "Id")
                    column.Visible = false;
            }
        }

        private void PopulatePaymentsDataGrid()
        {
            var payments = DatabaseModel.Instance.NxenesPagesas
               .Where(x => x.NxenesId == StudentID && x.Pagesa != null)
               .Select(x =>
                new
                {
                    Id = x.NxenesPageseId,
                    Name = x.Pagesa.Sherbimet.Pershkrimi,
                    Total = x.Pagesa.ShumaPaguar,
                }).ToList();
            dtgPayments.DataSource = payments;

            foreach (DataGridViewColumn column in dtgPayments.Columns)
            {
                if (column.Name == "Id")
                    column.Visible = false;
            }
        }
    }
}
