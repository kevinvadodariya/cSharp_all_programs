using System;
using System.Collections.Generic;

namespace DbFirstApiCRUD.Models;

public partial class StudentInfo
{
    public int Id { get; set; }

    public string StudName { get; set; } = null!;

    public string StudFname { get; set; } = null!;

    public int Age { get; set; }

    public int Class { get; set; }

    public string Div { get; set; } = null!;
}
