using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneExapmpe.concrete
{
    public class Samsung:BasePhone
    {
        public Samsung()
        {
            soundPath = Environment.CurrentDirectory.Replace("bin\\Debug", "Resources") + "\\samsung.wav";
            soundPlayer.SoundLocation = soundPath;//müziği değiştirdik
        }
        public override void PlaySound()
        {
            Thread.Sleep(200);//tıkladıktan sonra 200ms geç başlar.
            base.PlaySound();
        }
       
    }
}
