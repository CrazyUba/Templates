using System;

namespace MyFamousLibrary
{
    /// <summary>
    /// This is my class 'Person'
    /// </summary>
    public class Person
    {
        private string name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        /// <exception cref="ArgumentNullException">Name</exception>
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(Name));
                name = value;
            }
        }

        private int age;


        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">Age</exception>
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0 || age > 150) throw new ArgumentOutOfRangeException(nameof(Age));

                age = value;

            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// Text before Person
        public Person()
        {
            Name = "Peter";
        }

        /// <summary>
        /// Increments the age.
        /// </summary>
        /// <param name="years">Used to define the incrementation step</param>
        /// <paramref name="years">Used to define the incrementation step</paramref>
        public void IncrementAge(int years)
        {
            Age += years;
            return;
        }

        /// <summary>
        /// Description of myMethod
        /// </summary>
        /// <param name="a">Description of a ...</param>
        /// <param name="b">Description of b ...</param>
        private void myMethodWithTwoParams(int a, int b)
        {
            return;
        }


        /// <summary>
        /// Description of this method ...
        /// </summary>
        /// <param name="name">Description of name ...</param>
        /// <returns>Returns an empty string</returns>
        public string mySecondMethodWithReturnvalue(string name)
        {
            return "";
        }

        /// <summary>
        /// Description of this method ...
        /// </summary>
        /// <remarks>Some additional informations ...<see cref="Age"/></remarks>
        /// 
        public void myThirdMethodWithRemark()
        {

        }

        /// <summary>
        /// Description of this method ...
        /// </summary>
        /// <typeparam name="T">Description of T ...</typeparam>
        public void myGenericMethod<T>()
        {

        }

        /// <summary>
        /// Mies the private method.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>The sum of a and b</returns>
        private string myPrivateMethod(int a, int b)
        {
            return (a + b).ToString();
        }

        /// <summary>
        /// Adds the person.
        /// </summary>
        /// <param name="a">a. Further descr....</param>
        /// <returns>Returns an empty string</returns>
        public string AddPerson(int a)
        {
            return "";
        }

        

    }
}
