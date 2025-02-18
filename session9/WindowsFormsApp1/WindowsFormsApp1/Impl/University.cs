﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.Impl {


    public class University : Institute {

        // PROPERTIES
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }


        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }
        


        // CONSTRUCTOR
        public University() {

        }

        //  METHODS
        public void Init() {

            List<Course> courses = new List<Course>();

            Course physics1 = new Course() {
                Subject = "Quantum Physics",
                Category = CoursesCategoryEnum.Physics,
                Hours = 100
            };
            courses.Add(physics1);


            Course physics2 = new Course() {
                Subject = "Electo-Dynamics",
                Category = CoursesCategoryEnum.Physics,
                Hours = 50
            };
            courses.Add(physics2);

            Course static1 = new Course();
            static1.Subject = "Static";
            static1.Category = CoursesCategoryEnum.CivilEngineering;
            static1.Hours = 500;
            
            courses.Add(static1);


            List<Course> physicsCourses = courses.FindAll(x => x.Category == CoursesCategoryEnum.Physics);


            List<Course> physicsCourses100  = physicsCourses.FindAll(course => course.Hours >= 100);



            List<Course> physicsCourses2 = new List<Course>(); 
            foreach  (Course x in courses) {

                if (x.Category == CoursesCategoryEnum.Physics && x.Hours >= 100) {
                    physicsCourses2.Add(x);
                }
            }

            List<Course> physicsCourses3 = new List<Course>();
            foreach (Course y in courses) {

                if (y.Hours >= 100) {
                    physicsCourses3.Add(y);
                }
            }




        }

        public void SetCourse() {


            //Courses physics1 = new Courses();
            //physics1.Category = CoursesCategoryEnum.Physics;

           


        }

        public void SetGrade(CoursesCategoryEnum coursesCategory) {

            decimal modifier = 0;

            switch (coursesCategory) {
                case CoursesCategoryEnum.Physics:
                    modifier = 0.8m;
                    break;
                case CoursesCategoryEnum.Mathematics:
                    modifier = 0.9m;
                    break;
                case CoursesCategoryEnum.Sociology:
                    modifier = 0.5m;
                    break;
                case CoursesCategoryEnum.Chemistry:
                    modifier = 0.66m;
                    break;
                case CoursesCategoryEnum.Financial:
                    modifier = 0.8m;
                    break;
            }


            if (coursesCategory == CoursesCategoryEnum.Physics) { 
            
            
            }

            


        }


        // crud

        public void DeleteScheduledCourse(Guid scheduleID) {

            //Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);
            //ScheduledCourses.Remove(schedule);

            ScheduledCourses.RemoveAll(x => x.ID == scheduleID);
        }

        public void AddScheduledCourse(Guid courseID, Guid professorID, DateTime callendar) {

            // Verb (Action) -> Object

            Schedule schedule = new Schedule() {
                Callendar = callendar,
                CourseID = courseID,
                ProfessorID = professorID
               
            };

            ScheduledCourses.Add(schedule);
        }

        public void UpdateScheduledCourse(Guid scheduleID, DateTime callendar) {

            // locate
            Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);
            
            UpdateScheduledCourse(scheduleID, Guid.Empty, Guid.Empty, callendar);
        }

        public void UpdateScheduledCourse(Guid scheduleID, Guid courseID, Guid professorID, DateTime callendar) {

            // locate
            Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);

            // update
            if (courseID != Guid.Empty) {
                schedule.CourseID = courseID;
                // todo ....
            }
            

            if (professorID != Guid.Empty) {
                schedule.ProfessorID = professorID;

                // todo ....
            }

            schedule.Callendar = callendar;

        }


        public List<Schedule> GetScheduledCourses() {


            return ScheduledCourses;
        }

        public void GetstudentName(Student Name, Student Surname) {


        }






    }
     
    }

