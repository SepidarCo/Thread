using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleThread
{
    public class Person
    {
        public Person()
        {

        }

        public Person(int id, string name, string family)
        {
            this.Id = id;
            this.Name = name;
            this.Family = family;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public List<string> GetFullName(List<Person> people)
        {
            var fullName = new List<string>();
            foreach (var person in people)
            {
                fullName.Add(string.Format($"{person.Name} {person.Family}"));
            }
            return fullName;
        }

        public List<string> GetFullName(List<Person> people, int batchCount, int concurency)
        {
            var splitList = people.SplitListDistinct(batchCount);
            var stack = new ConcurrentStack<string>();

            Parallel.ForEach(splitList, new ParallelOptions { MaxDegreeOfParallelism = concurency }, (item) =>
            {
                var result = GetFullName(item);
                stack.PushRange(result.ToArray());
            });

            return stack.ToList();
        }
    }
}
