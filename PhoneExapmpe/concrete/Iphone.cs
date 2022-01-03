using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneExapmpe.concrete
{
    public class Iphone:BasePhone
    {
        public Iphone()
        {
            soundPath= Environment.CurrentDirectory.Replace("bin\\Debug", "Resources") + "\\iphone.wav";
            soundPlayer.SoundLocation = soundPath;//müziği değiştirdik
        }
        public override void StopSound()
        {
            base.StopSound();
            System.Windows.Forms.MessageBox.Show("sound durdu");
        }
    }
}
