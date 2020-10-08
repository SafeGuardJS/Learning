﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
