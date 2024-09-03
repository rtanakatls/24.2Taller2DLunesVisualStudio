using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.RPG
{
    internal class Game
    {
        private List<Enemy> enemies;
        private Player player;
        private int enemyIndex;

        public Game()
        {
            enemies=new List<Enemy>();
            enemyIndex = 0;
        }

        public void Execute()
        {
            CreatePlayerMenu();
            MainGameLoop();
        }

        private void CreatePlayerMenu()
        {
            string name;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            int life = 0;
            int damage = 0;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la vida");
                life = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el daño");
                damage = int.Parse(Console.ReadLine());

                if (life > 0 && damage > 0 && life + damage <= 100)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Los datos son inválidos");
                }
            }
            player = new Player(name, life, damage);
            Console.WriteLine($"Se creó el jugador");
            Console.WriteLine(player.GetData());
        }

        private void MainGameLoop()
        {
            enemies.Add(new Enemy("Enemigo 1", 10, 5));
            enemies.Add(new Enemy("Enemigo 2", 20, 4));
            enemies.Add(new Enemy("Enemigo 3", 30, 3));

            bool continueFlag = true;
            while(continueFlag)
            {
                PlayerTurn();
                if (!CheckEnemiesAlive())
                {
                    continueFlag = false;
                    Console.WriteLine("El jugador ganó");
                }
                else
                {

                    EnemyTurn();
                    if (!player.IsAlive())
                    {
                        continueFlag = false;
                        Console.WriteLine("El enemigo ganó");
                    }

                }

            }
        }

        private bool CheckEnemiesAlive()
        {
            foreach(Enemy enemy in enemies) 
            {
                if (enemy.IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        private void PlayerTurn()
        {
            bool continueFlag = true;
            while (continueFlag)
            {

                Console.WriteLine(player.GetData());
                for (int i = 0; i < enemies.Count; i++)
                {
                    if (enemies[i].IsAlive())
                    {
                        Console.WriteLine($"{i}. {enemies[i].GetData()}");
                    }
                }

                Console.WriteLine("Introduce el número del enemigo a atacar");
                int option = int.Parse(Console.ReadLine());
                if (option < 0 || option > enemies.Count || !enemies[option].IsAlive())
                {
                    Console.WriteLine("Opción no válida");
                }
                else
                {
                    Enemy enemy = enemies[option];
                    enemy.TakeDamage(player.GetDamage());
                    continueFlag = false;
                }
            }
        }

        private void EnemyTurn()
        {
            Enemy enemy = enemies[enemyIndex];
            Console.WriteLine($"Turno del enemigo {enemy.GetData()}");
            if (enemy.IsAlive())
            {
                Console.WriteLine("El enemigo le causa daño al jugador");
                player.TakeDamage(enemy.GetDamage());
            }
            else
            {
                Console.WriteLine("El enemigo está muerto");
            }
            enemyIndex++;
            if(enemyIndex >= enemies.Count)
            {
                enemyIndex = 0;
            }
        }

    }
}
