﻿using System;
using Twilio;

namespace Schedules.API.Models
{
  /// <summary>
  /// Citizen wants a reminder about a city service :)
  /// </summary>
  public class Reminder : IEquatable<Reminder>
  {
    public Reminder ()
    {

    }

    /// <summary>
    /// Gets or sets the Email address to send a reminder to.
    /// </summary>
    /// <value>The email.</value>
    public String Email {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the cell to send a reminder to.
    /// </summary>
    /// <value>The cell.</value>
    public String Cell {
      get;
      set;
    }

    public String Message {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets the remind on date. This is a simplified case.
    /// </summary>
    /// <value>The date to remind the user.</value>
    public DateTime RemindOn {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="Schedules.API.Reminder"/> is email verified.
    /// </summary>
    /// <value><c>true</c> if email verified; otherwise, <c>false</c>.</value>
    public bool EmailVerified {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="Schedules.API.Reminder"/> is cell verified.
    /// </summary>
    /// <value><c>true</c> if cell verified; otherwise, <c>false</c>.</value>
    public bool CellVerified {
      get;
      set;
    }

    public String Address {
      get;
      set;
    }

    public DateTime CreatedOn {
      get;
      set;
    }

    public string Send() {
      // Blech, don't do this for every instance
      var sid = System.Environment.GetEnvironmentVariable ("TWILIO-SID");
      var token = System.Environment.GetEnvironmentVariable ("TWILIO-TOKEN");
      var number = System.Environment.GetEnvironmentVariable ("TWILIO-NUMBER");
      var client = new TwilioRestClient (sid, token);
      var la = "+" + Cell;
      var sent = client.SendSmsMessage (number , la, Message);
      return (sent.RestException != null) ? sent.RestException.Message : string.Empty;
    }

    public bool Equals(Reminder other)
    {
      if (other == null)
        return false;

      return this.Cell == other.Cell
        && this.CellVerified == other.CellVerified
        && this.Email == other.Email
        && this.EmailVerified == other.EmailVerified
        && this.Message == other.Message;
    }

    public override bool Equals(Object obj)
    {
      return Equals (obj as Reminder);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
