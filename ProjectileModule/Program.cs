using ProjectileModule;

// Instantiate a list of projectiles
List<Projectile> bullets = new List<Projectile>();

int ammoCount = 10;

Weapon revolver = new Weapon();
revolver.WeaponName = "revolver";
revolver.CurrentAmmo = new List<Projectile>();

revolver.LoadProjectiles(ammoCount, "35mm");

Console.WriteLine($"Current weapon: {revolver}");

Console.WriteLine($"Currently Loaded:");

revolver.CurrentAmmo.ForEach(
    bullet => Console.WriteLine($"ID: {bullet.ProjectileId} Projectile Name: {bullet.ProjectileName}")
    );

var projectileToFireNext = revolver.CurrentAmmo.First();

revolver.FireProjectile(projectileToFireNext); // fire projectile, but track same bullet


