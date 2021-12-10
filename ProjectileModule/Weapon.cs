using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectileModule
{
    public class Weapon
    {
        public string WeaponName { get; set; }
        public List<Projectile> CurrentAmmo { get; set; }

        public List<Projectile> LoadProjectiles(int qty, string projectileName)
        {
            CurrentAmmo = new List<Projectile>();

            for (int i = 0; i < qty; i++)
            {
                CurrentAmmo.Add(new Projectile { ProjectileName = projectileName, ProjectileId = i });
            }

            return CurrentAmmo;
        }
    }
}
