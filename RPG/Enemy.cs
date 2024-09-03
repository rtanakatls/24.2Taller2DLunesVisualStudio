using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.RPG
{
    internal class Enemy
    {
        private string name;
        private int life;
        private int damage;

        public string Name { get { return name; } }

        public Enemy(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

        public void TakeDamage(int damage)
        {
            life += damage;
        }

        public bool IsAlive()
        {
            return life > 0;
        }

        public int GetDamage()
        {
            return -damage;
        }

        public string GetData()
        {
            return $"Enemigo:{name} - Vida:{life} - Daño:{damage}";
        }
    }
}
