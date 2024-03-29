﻿using AcademyApp.Business.Interface;
using AcademyApp.DataContext.Repositories;
using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Servicess
{
    public class StudentService : IStudent
    {
        private readonly StudentRepository _studentRepository;
        private readonly GroupRepository _groupRepository;
        private static int _count = 1;
        public StudentService()
        {
            _studentRepository = new ();
            _groupRepository = new  ();
        }
        public Student Create(Student student, string groupName)
        {
            var existGroup = _groupRepository.Get(n=>n.Name.ToLower()==groupName.ToLower());
            if (existGroup is null) return null;
            student.Id = _count;
            student.Group=existGroup;
            bool result=_studentRepository.Creat(student);
            if (!result) return null;
            _count++;
             return student;
            
        }
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> GetAll(string name)
        {
            return _studentRepository.GetAll(s => s.Name.ToLower() == name.ToLower());
        }

        public List<Student> GetAll(int age)
        {
            return _studentRepository.GetAll(a => a.Age == age);
        }

        public Student Get(int id)
        {
            return _studentRepository.Get(s => s.Id == id);
        }

        public Student Delete(int id)
        {
            var existStudent = _studentRepository.Get(s => s.Id == id);
            if (existStudent is null) return null;
            if (_studentRepository.Delete(existStudent))
            {
                return existStudent;
            }
            else
            {
                return null;
            }
        }

        public Student Update(int id, Student student, string groupName)
        {
            var existStudent = _studentRepository.Get(s=>s.Id==id);
            if (existStudent is null) return null;
            var existGroup=_groupRepository.Get(g=>g.Name==groupName);
            if (existGroup is null) return null;
            if (!string.IsNullOrEmpty(student.Name))
            {
                existStudent.Name = student.Name;
            }
            if (!string.IsNullOrEmpty(student.Surname))
            {
                existStudent.Surname = student.Surname;
            }
             existStudent.Group=student.Group;
            if (_studentRepository.Update(existStudent))
            {
                return existStudent;
            }
            else
            {
                return null;
            }
        }
    }
}
