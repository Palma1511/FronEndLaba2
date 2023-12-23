using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class GroupDto
    {
        public Guid Id { get; set; }
        public string NameGroup { get; set; }
        public List<StudentDto> Students { get; set; } = new List<StudentDto>();
    }
}
