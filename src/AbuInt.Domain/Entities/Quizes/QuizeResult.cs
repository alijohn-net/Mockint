﻿using AbuInt.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbuInt.Domain.Entities.Users;

namespace AbuInt.Domain.Entities.Quizes;

public class QuizeResult : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int QuizeId { get; set; }
    public Quize Quize { get; set; }

    public double Percentage { get; set; }
}