using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    interface IDrivable
    {
        void Start();
        void Stop();
        bool Started { get; }
    }
    interface ISteerable
    {
        void TurnLeft();
        void TurnRight();
    }
    interface IMovable: IDrivable, ISteerable
    {
        void Accelerate();
        void Brake();
    }
}
