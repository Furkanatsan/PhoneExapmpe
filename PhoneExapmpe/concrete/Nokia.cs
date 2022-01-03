using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhoneExapmpe.concrete
{
    public class Nokia:BasePhone

    {
        public Nokia()
        {

            soundPath = Environment.CurrentDirectory.Replace("bin\\Debug", "Resources") + "\\nokia.wav";
            soundPlayer.SoundLocation = soundPath;//müziği değiştirdik
        }
        public override void PlaySound()
        {
            Thread.Sleep(200);//tıkladıktan sonra 200ms geç başlar.
            base.PlaySound();
        }
        public override string ToString()
        {
            return $"Id:{Id}\r\nMarka:{Brand}\r\nModel:{Model}\r\nFiyat:{UnitPrice}";
        }
    }
}
