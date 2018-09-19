using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class Entity10 : IComparable<Entity10>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Entity10 other)
        {
            return Id.CompareTo(other.Id);
        }

        public static IComparer SortByIdAscendingOrder()
        {
            return new sortByIdAscendingOrder();
        }

        public static IComparer SortByIdDescendingOrder()
        {
            return new sortByIdDescendingOrder();
        }

        public static IComparer<Entity10> SortByNameAsceding()
        {
            return new sortByNameAsceding();
        }

        public static IComparer<Entity10> SortByNameDesceding()
        {
            return new sortByNameDesceding();
        }

        private class sortByIdAscendingOrder : IComparer
        {
            public int Compare(object x, object y)
            {
                if (((Entity10)x).Id > ((Entity10)y).Id)
                    return 1;

                if (((Entity10)x).Id < ((Entity10)y).Id)
                    return -1;

                return 0;
            }
        }

        private class sortByIdDescendingOrder : IComparer
        {
            public int Compare(object x, object y)
            {
                if (((Entity10)x).Id < ((Entity10)y).Id)
                    return 1;

                if (((Entity10)x).Id > ((Entity10)y).Id)
                    return -1;

                return 0;
            }
        }

        private class sortByNameAsceding : IComparer<Entity10>
        {
            public int Compare(Entity10 x, Entity10 y)
            {
                if (x == null || y == null)
                    return 0;

                var result = string.Compare(x.FirstName, y.FirstName);

                if (result == 0)
                    return string.Compare(x.LastName, y.LastName);
                return result;
            }
        }

        private class sortByNameDesceding : IComparer<Entity10>
        {
            public int Compare(Entity10 x, Entity10 y)
            {
                if (x == null || y == null)
                    return 0;

                var result = string.Compare(y.FirstName, x.FirstName);

                if (result == 0)
                    return string.Compare(y.LastName, x.LastName);
                return result;
            }
        }
    }

    public class IComparerEx
    {
        public static void Do()
        {
            List<Entity10> lst = new List<Entity10>()
            {
                new Entity10() { Id = 3, FirstName = "a", LastName = "p" },
                new Entity10() { Id = 2, FirstName = "a", LastName = "z" },
            new Entity10() { Id = 1, FirstName = "a", LastName = "l" }
            };

            lst.Sort();
            var ascByID =Entity10.SortByIdDescendingOrder();

            Entity10[] arr = new Entity10[]
            {
                new Entity10() { Id = 2, FirstName = "a", LastName = "z" },
                new Entity10() { Id = 1, FirstName = "a", LastName = "l" },
                new Entity10() { Id = 3, FirstName = "a", LastName = "p" }
            };

            Array.Sort(arr,Entity10.SortByIdDescendingOrder());
            Array.Sort(arr, Entity10.SortByIdAscendingOrder());
            Array.Sort(arr, Entity10.SortByNameAsceding());
            Array.Sort(arr, Entity10.SortByNameDesceding());
        }
    }
}
