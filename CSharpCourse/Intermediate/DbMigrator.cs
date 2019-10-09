using System;
namespace CSharpCourse.Intermediate
{
    public class DbMigrator
    {
        private readonly Logger logger;

        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.Log("we are migrating...");
        }
    }
}

// composition - a kind of relationship between two classes that allows one to contain the other.
// also called Has-A relationship eg - car has engine. benefits - code reuse, flexiblity, loose-coupling

// Advantager of composition over inheritance
// Problem with inheritance - 1.large hierarchies 2.fragility 3.tightly coupling
// any inheritance relationship can be translated to composition.
/**
 * class Animal{
 *  Eat(); 
 *  Sleep();     
 *  Swim(); //    class mamal{ Walk(); } 
 * }
 * class Person : Animal { .... }
 * class Dog : Animal { ... }
 * class GoldFish : Animal { now here goldfish class have walk behaviour but it don't walk
 * so we need to take out walk() and create new subclass class called mamal and then derive
 * Person and Dog from it.
 * }
 *
 * with composition - has a relationship
 * class Person{ private readonly Animal animal; private readonly Walkable walkable;}
 * class Dog { private readonly Animal animal; private readonly Walkable walkable;}
 * class GoldFish { private readonly Animal animal; private readonly Swimmable swimmable;}
 */

// Access Modifiers - 1.public - accessible from everywhere. 2.private - accessible only from the class.
// 3.protected - accessible only from class and its derived classes. 4.internal - often used with classes assessible only from the same assembly.
// 5.protected internal - accessible only from the same assembly or any derived classes.


