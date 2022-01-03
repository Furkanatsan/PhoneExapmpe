using PhoneExapmpe.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PhoneExapmpe.concrete
{
    public class BasePhone : IplaySound
    {
        public BasePhone()
        {
            soundPlayer = new SoundPlayer(soundPath);
        }
        protected SoundPlayer soundPlayer;
        protected string soundPath = Environment.CurrentDirectory.Replace("bin\\Debug", "Resources") + "\\default.wav";
                                  //@"C:\Users\FURKAN ATSAN\source\repos\PhoneExapmpe\PhoneExapmpe\Resources\default.wav";

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual void PlaySound()
        {
            soundPlayer.Play();
        }

        public virtual void StopSound()
        {
            soundPlayer.Stop();
        }
    }
}
