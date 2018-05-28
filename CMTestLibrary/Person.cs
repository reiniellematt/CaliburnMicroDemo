using System;
using System.Collections.Generic;
using System.Text;

namespace CMTestLibrary
{
    public class Person
    {
        /// <summary>
        /// The unique identifier for this person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
