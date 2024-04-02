using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_RansomNote
{
    public static class RansomeNote
    {
        public static bool Solution(string ransomeNote, string magazine) {
            foreach (char ch in ransomeNote.ToCharArray();) {
                if (magazine.IndexOf(ch)<0) return false;
                magazine = magazine.Remove(magazine.IndexOf(ch), 1);
            }
            GC.Collect();
            return true;
        }
    }
}
