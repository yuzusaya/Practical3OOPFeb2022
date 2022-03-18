// See https://aka.ms/new-console-template for more information

using Practical3;

/*
var studentId1 = "bcsxxxxx";
var studentName = "xxxx";
var studentId2 = "bcs123123"; 
var studentName2 = "xxxx";
Student student1 = new Student();

Shape shape1 = new Shape();
shape1.GetArea(2,2,2);
*/
Student student1 = new Student();
student1.PrintName();
Student student2 = new Student();
student2.StudentId = 2;
student2.PrintName();
var firstName = student2.FirstName;
