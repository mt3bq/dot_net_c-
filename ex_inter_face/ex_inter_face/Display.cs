using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex_inter_face;

namespace ex_inter_face
{
    class Display :hesap
    {

        private int witht;
        private int heigt;

        public Display() { }
        public Display(int w,int h) { 
            this.witht=w;
            this.heigt = h;
            }

        int hesap.wit {

        get { return this.witht; }
        set { this.witht = value; }
        }

        int hesap.heit {
            get { return this.heigt; }
            set { this.heigt = value; }

        }

        float hesap.aear() {
            return this.witht * this.heigt;
        }

    }
}
