using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student
{
    private string studentName;
    private int studentID;
    private string email;
    private string password;
    private string confirmPassword;
    private string universityMajor;
    private int phone;

    public ICollection<Event>? Events { get; set; }

    public Student(string studentName, int studentID, string email, string password, string confirmPassword, string universityMajor, int phone)
    {
        this.studentName = studentName;
        this.studentID = studentID;
        this.email = email;
        this.password = password;
        this.confirmPassword = confirmPassword;
        this.universityMajor = universityMajor;
        this.phone = phone;
    }

    [Required]
    public string StudentName 
    { 
        get { return studentName; } 
        set { studentName = value; } 
    }

    [Key] 
    public int StudentID 
    { 
        get { return studentID; } 
        set { studentID = value; } 
    }

    [Required]
    public string Email 
    { 
        get { return email; } 
        set { email = value; } 
    }

    [Required]
    public string Password 
    { 
        get { return password; } 
        set { password = value; } 
    }

    [Required]
    public string ConfirmPassword 
    { 
        get { return confirmPassword; } 
        set { confirmPassword = value; } 
    }

    [Required]
    public string UniversityMajor 
    { 
        get { return universityMajor; } 
        set { universityMajor = value; } 
    }

    [Required]
    public int Phone 
    { 
        get { return phone; } 
        set { phone = value; } 
    }
}
