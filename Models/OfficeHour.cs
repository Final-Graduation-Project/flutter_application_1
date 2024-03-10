using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class OfficeHour
{
    public int OfficeHourId { get; set; }
    public int TeacherId { get; set; }
    public DateTime TeacherFreeDay { get; set; }
    public DateTime TeacherFreeStartTime { get; set; }
    public DateTime TeacherFreeEndTime { get; set; }
    public string BuildingName { get; set; }
    public string RoomNumber { get; set; }

    public Teacher? Teacher { get; set; }
    

    public OfficeHour(int teacherId, DateTime teacherFreeDay, DateTime teacherFreeStartTime, DateTime teacherFreeEndTime, string buildingName, string roomNumber)
    {
        TeacherId = teacherId;
        TeacherFreeDay = teacherFreeDay;
        TeacherFreeStartTime = teacherFreeStartTime;
        TeacherFreeEndTime = teacherFreeEndTime;
        BuildingName = buildingName;
        RoomNumber = roomNumber;
    }
}
