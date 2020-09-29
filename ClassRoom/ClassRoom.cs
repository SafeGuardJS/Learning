using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }

        public void GetStudyFeedBack()
        {
            for(int i = 0; i < this.pupils.Length; i++)
            {
                this.pupils[i].Relax();
            }
        }
    }
}
