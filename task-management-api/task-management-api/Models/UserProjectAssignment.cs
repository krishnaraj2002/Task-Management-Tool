﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace task_management_api.Models
{
    public class UserProjectAssignment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public User User { get; set; }
        public Project Project { get; set; }
    }
}
