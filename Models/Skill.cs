using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public Profile User { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
    }

    public enum Level
    {
        Novice,
        Advanced,
        Expert
    }
}
