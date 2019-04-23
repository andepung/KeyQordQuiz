using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Quiz
{
    class Program
    {
        /*
                     ▄▄▄▄▄▄▄▄▄▄▄  ▄         ▄  ▄            ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
                    ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
                    ▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌          ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ 
                    ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌          
                    ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌          ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ 
                    ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
                    ▐░█▀▀▀▀█░█▀▀ ▐░▌       ▐░▌▐░▌          ▐░█▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀█░▌
                    ▐░▌     ▐░▌  ▐░▌       ▐░▌▐░▌          ▐░▌                    ▐░▌
                    ▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄█░▌
                    ▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
                     ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  
    ┌─┐┌─┐┌┐┌┌─┐┬─┐┌─┐┬    ┌┬┐┬ ┬┬┌┐┌┌─┐┌─┐  ┬┌┐┌  ┌─┐┬─┐┌┬┐┌─┐┬─┐  ┌┬┐┌─┐  ┌┐┌┌─┐┌┬┐  ┌┐ ┬─┐┌─┐┌─┐┬┌─  ┌┬┐┬ ┬┬┌─┐ 
    │ ┬├┤ │││├┤ ├┬┘├─┤│     │ ├─┤│││││ ┬└─┐  ││││  │ │├┬┘ ││├┤ ├┬┘   │ │ │  ││││ │ │   ├┴┐├┬┘├┤ ├─┤├┴┐   │ ├─┤│└─┐ 
    └─┘└─┘┘└┘└─┘┴└─┴ ┴┴─┘   ┴ ┴ ┴┴┘└┘└─┘└─┘  ┴┘└┘  └─┘┴└──┴┘└─┘┴└─   ┴ └─┘  ┘└┘└─┘ ┴   └─┘┴└─└─┘┴ ┴┴ ┴   ┴ ┴ ┴┴└─┘o             
                 these are OPTIONAL. More like recomendations so you dono't give yourself more work. 
                                                    ┌┐ ┬ ┬┌┬┐
                                                    ├┴┐│ │ │ 
                                                    └─┘└─┘ ┴ 
     ██╗   ██╗ ██████╗ ██╗   ██╗    ██████╗  ██████╗     ██╗   ██╗ ██████╗ ██╗   ██╗    ██████╗  ██████╗  ██████╗ 
     ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔══██╗██╔═══██╗    ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔══██╗██╔═══██╗██╔═══██╗
      ╚████╔╝ ██║   ██║██║   ██║    ██║  ██║██║   ██║     ╚████╔╝ ██║   ██║██║   ██║    ██████╔╝██║   ██║██║   ██║
       ╚██╔╝  ██║   ██║██║   ██║    ██║  ██║██║   ██║      ╚██╔╝  ██║   ██║██║   ██║    ██╔══██╗██║   ██║██║   ██║
        ██║   ╚██████╔╝╚██████╔╝    ██████╔╝╚██████╔╝       ██║   ╚██████╔╝╚██████╔╝    ██████╔╝╚██████╔╝╚██████╔╝
        ╚═╝    ╚═════╝  ╚═════╝     ╚═════╝  ╚═════╝        ╚═╝    ╚═════╝  ╚═════╝     ╚═════╝  ╚═════╝  ╚═════╝ 
                                                                                                             
         1. For each Quiz NO MORE than 100 questions, if you need more make another Quiz. 
         EX) Basic : REDUX  
         
         2. There is a generic question template in a region named generic. 
             
             


               _____                          _              
                /  '  _/_                    //              
             ,-/-,. . /  . . __  _      _   // __.  ____  _  
            (_/  (_/_<__(_/_/ (_</_    /_)_</_(_/|_/ / <_/_)_
                                      /                      
                                     '                       
             TODO Make one specifically on entity frameworks and LINQ
             TODO Add a property to question to have the answer actually print out like a definition.
             TODO Make ability to look back and take another quiz
             TODO Make a List of incorrectly answered questions. Once Quiz is "complete" go back and retry w/list. || MAKE CHOICE IF POINTS GIVEN||
             */
        static void Main(string[] args)
        {
            #region Questions

            #region Basic
            Question q1 = new Question(
        "What is a class?",
        "1. Variable/Instance has its own state\n" +
        "2. A blueprint for an object\n" +
        "3. Forward only, read only objects--cannot change database",
         2
        );
            Question q2 = new Question(
                "What is containment?",
                "1. Hidden functionality (Is a relationship)\n" +
                "2. A feature of a variable that helps determine how it can be used(was a relationship)\n" +
                "3. Complex datatype fields in a class (has a relationship)",
                 3
                );
            Question q3 = new Question(
                "What is encapsulation?",
                "1. Hidden functionality (Is a relationship)\n" +
                "2. A feature of a variable that helps determine how it can be used(was a relationship)\n" +
                "3. Complex datatype fields in a class (has a relationship)",
                 1
                );
            Question q4 = new Question(
                "What is a inheritance?",
                "1. Variable/Instance has its own state\n" +
                "2. Define what's possible\n" +
                "3. Ability to pass members to decendent classes",
                 3
                );
            Question q5 = new Question(
                "What is an Assembly?",
                "1. Project\n" +
                "2. Solution\n" +
                "3. Portfolio",
                 1
                );
            Question q6 = new Question(
                "What is Polymorphism?",
                "1. Changing the data stored in a variable of one datatype into data of another non-similar datatype\n" +
                "2. Different implemented methods in the same class\n" +
                "3. A feature of the C# that restricts a variable to only ever be the datatype that it was declared as",
                 2
                );
            Question q7 = new Question(
                "What is a Parameter?",
                "1. Actual value of formally defined objects in a method\n" +
                "2. Define what's possible\n" +
                "3. Formally defined objects needed for a method",
                 3
                );
            Question q8 = new Question(
                "What is an Argument?",
                "1. Formally defined objects needed for a method\n" +
                "2. Actual value of Formally defined objects in a method\n" +
                "3. Methods to respond to occurrences",
                 2
                );
            Question q9 = new Question(
                "What is Static?",
                "1. Called from the class/keyword\n" +
                "2. Only available to _this_ class and decedents. \n" +
                "3. Called from the object",
                 1
                );
            Question q10 = new Question(
                "What is an object?",
                "1. Variable/Instance that has its own state\n" +
                "2. Define what's possible\n" +
                "3. Current Value of a variable",
                 1
                );
            Question q11 = new Question(
                "What is Instance?",
                "1. Called from the class/keyword\n" +
                "2. Only available to THIS class and decedents. \n" +
                "3. Called from the object",
                 3
                );
            Question q12 = new Question(
                "What is a Datatype?",
                "1. A non-reusable code component\n" +
                "2. A feature of a variable that helps determine how it can be used\n" +
                "3. A storage container for information that is reusable within a program",
                 2
                );
            Question q13 = new Question(
                "What is Virtual?",
                "1. Method that can't be overwritten\n" +
                "2. Method to be overwritten in a child class\n" +
                "3. Called from class name. Shared across instances of the class",
                 2
                );
            Question q14 = new Question(
                "What is Compiling?",
                "1. Variable/Instance has its own state\n" +
                "2. Define what's possible\n" +
                "3. To organize all program files to work together to run a program, including setting aside memory for variables and making files call to each other.",
                 3
                );
            Question q15 = new Question(
                "What is a Data reader?",
                "1. Read only objects\n" +
                "2. Formally defined objects needed for a method\n" +
                "3. A file that contains code that may be used (called) by your application.",
                 1
                );
            Question q16 = new Question(
                "What is a constructor?",
                "1. A storage container for information that is reusable within a program\n" +
                "2. Define what's possible\n" +
                "3. Specialized methods that return an object of THIS type.",
                 3
                );
            Question q17 = new Question(
                "What is a const variable?",
                "1. Construction\n" +
                "2. Consternation\n" +
                "3. Constant",
                 3
                );
            Question q18 = new Question(
                "What is an Abstract()?",
                "1. In a method, must be inherited\n" +
                "2. In a method, optionally inherited\n" +
                "3. In a method, cannot be inherited",
                 1
                );
            Question q19 = new Question(
                "What is a : ?",
                "1. Bracket\n" +
                "2. Colon\n" +
                "3. Semicolon",
                 2
                );
            Question q20 = new Question(
                "What is a class member?",
                "1. Internal\n" +
                "2. Static\n" +
                "3. Properties",
                 3
                );
            Question q21 = new Question(
                "What is an Escape Sequence?",
                "1. A way to put characters into strings that are impossible to insert literally.(starts with a backslash)\n" +
                "2. A way of typing a string and showing its output literally on the screen, including spacing, line break\n" +
                "3. A character that checks the value of objects on either side of it and returns a bool value of true or false",
                 1
                );
            Question q22 = new Question(
                "What does abstract mean?",
                "1. only members of this project/assembly have access\n" +
                "2. Cannot be inherited\n" +
                "3. Inheritance only",
                 3
                );
            Question q23 = new Question(
                "What is an Identifier?",
                "1. Defines access level in code\n" +
                "2. The name\n" +
                "3. A blueprint for an object",
                 2
                );
            Question q24 = new Question(
                "What is Sealed?",
                "1. Inheritance only\n" +
                "2. Only accessible in the class declared and in inheriting members\n" +
                "3. Cannot be inherited",
                 3
                );
            Question q25 = new Question(
                "What is an Interface?",
                "1. The act of creating an enforceable rule structure between 2 or more otherwise unrelated classes\n" +
                "2. A system of tools, features, and functionality that is pre-built that makes writing software and web sites quicker and easier\n" +
                "3. A piece of software that makes writing and running applications easier.",
                 1
                );
            Question q26 = new Question(
                "What is an Exception ?",
                "1. A way to put characters into strings that are impossible to insert literally.\n" +
                "2. Used to signal the occurrence of an anomalous situation during the program execution.\n" +
                "3. Anything that interrupts the normal execution of an Assembly",
                 3
                );
            Question q27 = new Question(
                "What does Implement mean?",
                "1. Checking the value of an object\n" +
                "2. To give value or change the value assigned to a variable.\n" +
                "3. The act of applying an interface to a class",
                 3
                );
            Question q28 = new Question(
                "What is a Project?",
                "1. A file that cannot be inherited.\n" +
                "2. A reusable code component.\n" +
                "3. Code set that is designed to perform a specific function or set of functions",
                 3
                );
            Question q29 = new Question(
                "What are the 4 Base Properties of the Exception Class?",
                "1. Source, Modify, StackTrace, Implement\n" +
                "2. Source, Message, StackTrace, Data\n" +
                "3. Source, Message, StackTrace, Implement",
                 2
                );
            Question q30 = new Question(
                "What is a Stack(list)?",
                "1. Non-generic version of a list. It is growable unlike another non-generic.\n" +
                "2. A FIFO (first in, first out) collection. Potential uses for this are call center routing or order fulfillment collections\n" +
                "3. a LIFO (last in, first out) collection. Potential uses for this are functions like undo or a back button (in a browser)",
                3

                );
            Question q31 = new Question(
                "What is an ArrayList?",
                "1. This is the non-generic version of a list. It is growable unlike another non-generic\n" +
                "2. A Strongly-typed collection of specific objects, stored by index, and best used with small to medium collections\n" +
                "3. A strongly typed collection that uses the key as a reference to store a value. By specifying a key, you can retrieve the value.",
                1

                );
            Question q32 = new Question(
                "What is Queue?",
                "1. Non-generic version of a list. It is growable unlike another non-generic.\n" +
                "2. A FIFO (first in, first out) collection. Potential uses for this are call center routing or order fulfillment collections\n" +
                "3. a LIFO (last in, first out) collection. Potential uses for this are functions like undo or a back button (in a browser)",
                2
                );
            Question q33 = new Question(
                "What is a List?",
                "1. This is the non-generic version of a list. It is growable unlike another non-generic\n" +
                "2. A Strongly-typed collection of specific objects, stored by index, and best used with small to medium collections\n" +
                "3. A strongly typed collection that uses the key as a reference to store a value. By specifying a key, you can retrieve the value.",
                2
                );

            Question q34 = new Question(
                "What is a Dictionary?",
                "1. This is the non-generic version of a list. It is growable unlike another non-generic\n" +
                "2. A Strongly-typed collection of specific objects, stored by index, and best used with small to medium collections\n" +
                "3. A strongly typed collection that uses the key as a reference to store a value. By specifying a key, you can retrieve the value.",

                3
                );
            Question q35 = new Question(
                "What is the Non-generic version of a Dictionary?",
                "1. StackTrace\n" +
                "2. Hashtable\n" +
                "3. HistTable",
                2
                );
            Question q36 = new Question(
                "What is a Generic Collection?",
                "1. Collection that accepts objects of a specific type\n" +
                "2. Collection is one that accepts all data types\n" +
                "3. Code set that is designed to perform a specific function",

                1);
            Question q37 = new Question(
                "What does it mean to Instantiate?",
                "1. Copying the value of a variable of one datatype to a variable of a similar, but different datatype\n" +
                "2. To have an instance be represented by an actual example.\n" +
                "3. Information captured from the application’s user",
                2
                );
            Question q38 = new Question(
                "What is another name for an interface?",
                "1. Blue Print\n" +
                "2. Project\n" +
                "3. Contract",
                3
                );
            Question q39 = new Question(
                "What is a Namespace?",
                "1. Logical system for organizing code\n" +
                "2. A system of tools, features, and functionality that is pre-built that makes writing software and web sites quicker and easier.\n" +
                "3. A program that runs within Windows, rather than a desktop.",

                1
                );
            Question q40 = new Question(
                "What is .Net?",
                "1.  A system of tools, features, and functionality that is pre-built that makes writing software and web sites quicker and easier.\n" +
                "2. A framework developed by Microsoft for software and web development.\n" +
                "3. A piece of software that makes writing and running applications easier",

                2
                );
            Question q41 = new Question(
                "What does Type Safe mean?",
                "1. Restricts a project to only ever be the class type that it was declared as\n" +
                "2. Restricts a class to only ever be the variable type that it was declared as\n" +
                "3. Restricts a variable to only ever be the datatype that it was declared as",
                3
                );
            Question q42 = new Question(
                "What is Windows Application?",
                "1. A program that runs within Windows, usually on a desktop rather than the internet.\n" +
                "2. A program that runs on the internet, rather than a desktop.\n" +
                "3. A file that contains code that may be used (called) by your application. Classes are stored inside projects.",

                1
                );
            Question q43 = new Question(
                "What is Concatenation?",
                "1. To create a variable using a datatype and name\n" +
                "2. To give value or change the value assigned to a variable\n" +
                "3. Putting two strings together using a plus sign",

                3
                );
            Question q44 = new Question(
                "What is it to Declare?",
                "1. A reusable code component\n" +
                "2. To create a variable using a datatype and name\n" +
                "3. Change the value assigned to a variable",

                2
                );
            Question q45 = new Question(
                "What is Implicit Casting?",
                "1. Copying the value from a larger datatype to a smaller datatype\n" +
                "2. Copying the value of a variable of one datatype to the same datatype\n" +
                "3. Copying the value from a smaller datatype to a larger datatype",

                3
                );
            Question q46 = new Question(
                "What is a bit?",
                "1. A binary value of 0 or 1. 0 indicates “false” or “off”. \n" +
                "2. Only accepts a value of true or false\n" +
                "3. Stores a value from 0-255",
                1
                );
            Question q47 = new Question(
                "What is Explicit Casting?",
                "1. Copying the value from a larger datatype to a smaller datatype\n" +
                "2. Copying the value of a variable of one datatype to the same datatype\n" +
                "3. Copying the value from a smaller datatype to a larger datatype",


                1
                );
            Question q48 = new Question(
                "What is Truncation?",
                "1. Occurs when the value contained in one datatype cannot fit into a variable of a smaller datatype. \n" +
                "2. Copying the value of a variable of one datatype to a variable of a similar, but different datatype\n" +
                "3. A naming convention",
                1
                );
            Question q49 = new Question(
                "What is a Collection?",
                "1. Information captured from the application’s user\n" +
                "2. Multiple items grouped together, often of a similar or identical datatype.\n" +
                "3. A way to show output to an application’s user by putting information into placeholders within the output string. ",
                2
                );
            Question q50 = new Question(
                "What is the Hungarian convention?",
                "1. Uses a lowercase first word that represents a description of type of object the variable is, followed by a capital first letter for each following word in the name\n" +
                "2. Uses a lowercase first letter for the first word in the name, followed by a capital first letter for each following word\n" +
                "3. Uses a capital letter for all individual words in the name",
                1
                );
            Question q51 = new Question(
                "Which two are Sequential Collections?",
                "1. Stack & Queue\n" +
                "2. Dictionary & Hashtables\n" +
                "3. List & ArrayList",
                1

                );
            Question q52 = new Question(
                "What is a Non-Generic Collection?",
                "1. Accepts all data types and stores them in a single type\n" +
                "2. Accepts objects of a specific type\n" +
                "3. Accepts classes of different types but returns one value",
                1

                );
            Question q53 = new Question(
                "What is an Inferred Data Type?",
                "1. Datatype inherited from a parent class\n" +
                "2. Uses the *var* keyword and the compiler can figure out what data type the variable should be declared as using context\n" +
                "3. Uses the string and char datatype to contruct a ToSting() out of any datatype",
                2

                );
            Question q54 = new Question(
                "What is an Anonymous Type?",
                "1. Adding new behavior to existing classes without having to put that method in the original class file\n" +
                "2. Creating new types of objects on the fly without needing to create a class for them\n" +
                "3. Allows us to pass parameters and an expression for that parameter into the extension methods in .NET",
                2

                );
            Question q55 = new Question(
                "What is a Lambda Expression?",
                "1. Allow us to easily create Properties in our classes without having to specify a private field\n" +
                "2. Allows us to pass parameters and an expression for that parameter into the extension methods in .NET\n" +
                "3. Uses the *var* keyword and the compiler can figure out what data type the variable should be declared as using context",
                2

                );
            Question q56 = new Question(
                "What is an Automatic Property?",
                "1. Allow us to easily create Properties in our classes without having to specify a private field\n" +
                "2. Allows anything to interrupt the normal execution of an Assembly\n" +
                "3. Allow us to pass parameters and an expression for that parameter into the extension methods in .NET",
                1

                );
            Question q57 = new Question(
                "What are the two types of Methods?",
                "1. Virtual & Override\n" +
                "2. Parameters & Arguments\n" +
                "3. Static & Instance",
                3

                );
            Question q58 = new Question(
                "What is a Complex Datatype?",
                "1. A type of variable that is called from a class name with no contructor\n" +
                "2. A type of variable that is called from an instance of some variable or other object\n" +
                "3. A type of variable that requires the “new” keyword to call the constructor for the object.",
                3

                );
            Question q59 = new Question(
                "What is a Using Statement?",
                "1. A pointer to look at another namespace (aka Project) and bring in the files that exist in it.\n" +
                "2. Used to create other languages and define what the information that is being represented means\n" +
                "3. An optional statement that can be added to the top of a class file that references the namespace for files that exist outside of the namespace",
                3

                );
            Question q60 = new Question(
                "What is a Test Harness?",
                "1. A class used to test custom classes and methods without having to create the entire program first\n" +
                "2. A class used to Truncate custom classes and methods\n" +
                "3. A class used to test custom classes and methods by creating the entire program first",
                1

                );
            Question q61 = new Question("What does type safe mean?",
                "1. The type of a variable is inferred but allows you to use one type as another.\n" +
                "2. The type of a variable is known or inferred at compile time. Does not allow you to use one type as another.\n" +
                "3. The type of a variable is not known or inferred at compile time. Allows you to use type as another.",
                2);
            Question q62 = new Question("What does LINQ stand for?",
                "1. Language Intergrate Query.\n" +
                "2. Language Intergrate I(n)ferred Query.\n" +
                "3. Language Intergrate Network Query." +
                "4. Truth, justice and the American way",
                1
                );
            Question q63 = new Question("What is LINQ?",
                "1. A type of list added to .Net languages to make data manipulation easier. SQL-Like.\n" +
                "2. Keywords added to .Net languages to make class manipulation easier. SQL-Like.\n" +
                "3. A syntax added to .Net languages to make data manipulation easier. SQL-Like.",
                3);
            Question q64 = new Question("What is an example of LINQ? (BEST ANSWER)",
                "1. Deferred Inheritance, Lambda, cross-language \n" +
                "2. Deferred Execution, Lambda, cross-language \n" +
                "3. Deferred Expression, Lambda, cross-language ",
                2);
            Question q65 = new Question("What is Differerd Execution?",
                "1. Does not execute LINQ query will show results as a bool\n" +
                "2. Executes LINQ query before results are needed\n" +
                "3. Does not execute LINQ query until results are needed",
                3);
            Question q66 = new Question("What is Entity Frameworks?",
                "1. A mapper tool that helps automate setting up our domain models that map back to out database tables and our access layer for common CRUD functionality with database.\n" +
                "2. A programming architecture that helps automate setting up our generic lists that map back to out database tables and our access to the database.\n" +
                "3. A programming architecture that helps automate setting up our interface models that map back to out database tables and our access layer for common functionality with database.",
                1);
            #endregion
            #region JavaScript
            Question j1 = new Question(
                "What is a Domain?",
                "1. A business that supplies technologies and services needed for a webpage to be viewed on the internet\n" +
                "2. Part of a network address that identifies it as belonging to a particular domain\n" +
                "3. Protocol used to transfer website files from a local machine to an FTP server",
                2

                );
            Question j2 = new Question(
                "What is a Host?",
                "1. Part of a network address that identifies it as belonging to a particular domain.\n" +
                "2. A business that supplies technologies and services needed for a webpage to be viewed on the internet.\n" +
                "3. Technology server for managing solutions and assemblies before deploying a project",
                2
                );
            Question j3 = new Question(
                "What does RWD stand for?",
                "1. Responsive Web Domain\n" +
                "2. Responsive Web Deployment\n" +
                "3. Responsive Web Design",
                3
                );
            Question j4 = new Question(
               "What is a Media Query?",
               "1. Adaptable content rendering in response to conditions like screen resolution.\n" +
               "2. Part of a URL that contains data including fields added to a base URL by a browser or application\n" +
               "3. Checks user inputs are valid",
               1

               );
            Question j5 = new Question(
              "What is a Query String?",
              "1. A placeholder for storing data\n" +
              "2. Checks user inputs are valid\n" +
              "3. Part of a URL that contains data including fields added to a base URL by a browser or application",
              3

              );
            Question j6 = new Question(
              "What does it mean to Debug?",
              "1. Identify and remove errors\n" +
              "2. Design and development responding to a user’s behavior\n" +
              "3. Applying new JS rules",
              1

              );
            Question j7 = new Question(
              "What is a DOMTokenList?",
              "1. Will check to see if that list contains a class attribute\n" +
              "2. A set of space separated tokens\n" +
              "3. A method() that determines breakpoints in a List",
              2

              );
            Question j8 = new Question(
              "What is a Regular Expression?",
              "1. Special text string for describing a search pattern\n" +
              "2. Using a system as a set of objects that can be controlled and manipulated\n" +
              "3. Ensures an operation is working on the correct datatype, returns a bool",
              1

              );
            Question j9 = new Question(
              "What is JSON?",
              "1. A tool that allows you to view items that you log in your JavaScript code and error messages\n" +
              "2. Format for structuring data to transmit between a server and application\n" +
              "3. A set of space separated tokens",
              2

              );
            Question j10 = new Question(
             "What is DOM?",
             "1. Adaptable content rendering in response to conditions like screen resolution\n" +
             "2. Part of a URL that contains data including fields added to a base URL by a browser or application\n" +
             "3. The logical structure of documents and the way a document is accessed and manipulated",
             3

             );
            #endregion
            #region SQL

            #endregion
            #region Html/Css
            Question h1 = new Question(
               "What is the ehe latest version of the HTML standard?",
               "1. HTML5\n" +
               "2. HTML6\n" +
               "3. XHTML6",
               1

               );
            Question h2 = new Question(
                "Which is XHTML?",
                "1. The last widely implemented version of HTML, known for its stricter syntax to aid in easier validation.\n" +
                "2. The latest version of the HTML standard\n" +
                "3. The primary building block for marking up content in an HTML document.",
                3
                );
            Question h3 = new Question(
                "What is the Head tag?",
                "1. This is the second and last tag nested directly inside the HTML tag, and contains the content of the page that will be rendered onscreen in the browser.\n" +
                "2. The tag that immediately follows the DTD and surrounds all other content in the file.\n" +
                "3. The first tag placed immediately inside the HTML tag. It provides code about the document, rather than actual page content.",
                3
                );
            Question h4 = new Question(
               "What is a User Interface?",
               "1. A program that can make requests for Web pages and renders the result\n" +
               "2. The environment where users interact with a program. Examples include console applications, Windows applications, and Web applications.\n" +
               "3. The software infrastructure for a private network",
               2

               );
            Question h5 = new Question(
              "What is HTTP?",
              "1. The core language for structuring web page content\n" +
              "2. The communications standard that browsers use to communicate with web servers, allowing them to request pages and pass user input over the Internet.\n" +
              "3. The combined collection of all website content available on the Internet.",
              2

              );
            Question h6 = new Question(
              "What is HTML?",
              "1. The combined collection of all website content available on the Internet.\n" +
              "2. Allows browser to communicate with web servers, but it is slower and more secure because it handles the encryption and decryption of information being passed.\n" +
              "3. The core language for structuring web page content",
              3

              );
            Question h7 = new Question(
              "What is CSS?",
              "1. A language primarily known for providing event handling, form validation and programming logic in the browser, extending the functionality of web page content.\n" +
              "2. A language that provides formatting and layout for web page content.\n" +
              "3. The environment where users interact with a program.",
              2

              );
            Question h8 = new Question(
              "What is the Internet?",
              "1. The combined hardware and software infrastructure that provides the world’s largest computer network, providing a platform for shared information and communications.\n" +
              "2. The combined hardware and software infrastructure for a private network that provides content with a smaller distribution.\n" +
              "3. The combined collection of all website content available on the Internet.",
              1

              );
            Question h9 = new Question(
              "What is the World Wide Web?",
              "1. The user-friendly name that is being rented and associated with a website available on the Web.\n" +
              "2. The combined collection of all website content available on the Internet.\n" +
              "3. The full address of a resource on the Internet, including the domain.",
              2

              );
            Question h10 = new Question(
             "What is Intranet?",
             "1. The combined hardware and software infrastructure for a private network that provides content with a smaller distribution.\n" +
             "2. A program that can make requests for Web pages and renders the resulting HTML, CSS, JavaScript and images into a usable interface.\n" +
             "3. The software that handles hosting a website (a folder of webpages), responding with the appropriate code and resources when a request is made.",
             1

             );
            #endregion

            #region Generic
            /*
            Question 1 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
            Question 2 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
            Question 3 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
             Question 4 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
              Question 5 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
              Question 6 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
              Question 7 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
              Question 8 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
              Question 9 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
               Question 10 = new Question(
                "What is ?",
                "1. \n" +
                "2. \n" +
                "3. ",

                );
             */
            #endregion
            #endregion

            #region Lists
            List<Question> Basic = new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37, q38, q39, q40, q41, q42, q43, q44, q45, q46, q47, q48, q49, q50, q51, q52, q53, q54, q55, q56, q57, q58, q59, q60, q61, q62, q63, q64, q65, q66 };

            List<Question> JQueryJavaScript = new List<Question>() { j1, j2, j3, j4, j5, j6, j7, j8, j9, j10 };

            List<Question> SQL = new List<Question>();

            List<Question> HTML_CSS = new List<Question>() { h1, h2, h3, h4, h5, h6, h7, h8, h9, h10 };

            List<Question> Wrong = new List<Question>();
            #endregion

            bool repeatQuiz = false;
            int scoreB = 0;
            int scoreJ = 0;
            int scoreH = 0;
            #region Title
            Console.WriteLine(
                    @"
 ▄████████  ▄██████▄  ████████▄   ▄█  ███▄▄▄▄      ▄██████▄       
███    ███ ███    ███ ███   ▀███ ███  ███▀▀▀██▄   ███    ███      
███    █▀  ███    ███ ███    ███ ███▌ ███   ███   ███    █▀       
███        ███    ███ ███    ███ ███▌ ███   ███  ▄███             
███        ███    ███ ███    ███ ███▌ ███   ███ ▀▀███ ████▄       
███    █▄  ███    ███ ███    ███ ███  ███   ███   ███    ███      
███    ███ ███    ███ ███   ▄███ ███  ███   ███   ███    ███      
████████▀   ▀██████▀  ████████▀  █▀    ▀█   █▀    ████████▀       
                                                                  
          ████████▄   ███    █▄   ▄█   ▄███████▄                  
          ███    ███  ███    ███ ███  ██▀     ▄██                 
          ███    ███  ███    ███ ███▌       ▄███▀                 
          ███    ███  ███    ███ ███▌  ▀█▀▄███▀▄▄                 
          ███    ███  ███    ███ ███▌   ▄███▀   ▀                 
          ███    ███  ███    ███ ███  ▄███▀                       
          ███  ▀ ███  ███    ███ ███  ███▄     ▄█                 
           ▀██████▀▄█ ████████▀  █▀    ▀████████▀                 
                                                                  "
                    );
            Thread.Sleep(150);
            string titlepage = "Press any key to continue...";

            foreach (char i in titlepage)
            {
                Thread.Sleep(75);
                Console.Write(i);
            }

            #endregion

            // Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            int outOF = Basic.Count + JQueryJavaScript.Count + SQL.Count + HTML_CSS.Count;
            do
            {
                repeatQuiz = false;
                #region Quiz art
                string bArt = @"
        ██████╗  █████╗ ███████╗██╗ ██████╗
        ██╔══██╗██╔══██╗██╔════╝██║██╔════╝
        ██████╔╝███████║███████╗██║██║     
        ██╔══██╗██╔══██║╚════██║██║██║     
        ██████╔╝██║  ██║███████║██║╚██████╗
        ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝ ╚═════╝";
                string jArt = @"
             ██╗ █████╗ ██╗   ██╗ █████╗ ███████╗ ██████╗██████╗ ██╗██████╗ ████████╗
             ██║██╔══██╗██║   ██║██╔══██╗██╔════╝██╔════╝██╔══██╗██║██╔══██╗╚══██╔══╝
             ██║███████║██║   ██║███████║███████╗██║     ██████╔╝██║██████╔╝   ██║   
        ██   ██║██╔══██║╚██╗ ██╔╝██╔══██║╚════██║██║     ██╔══██╗██║██╔═══╝    ██║   
        ╚█████╔╝██║  ██║ ╚████╔╝ ██║  ██║███████║╚██████╗██║  ██║██║██║        ██║   
         ╚════╝ ╚═╝  ╚═╝  ╚═══╝  ╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝╚═╝        ╚═╝ ";
                string sArt = @"
        ███████╗ ██████╗ ██╗     
        ██╔════╝██╔═══██╗██║     
        ███████╗██║   ██║██║     
        ╚════██║██║▄▄ ██║██║     
        ███████║╚██████╔╝███████╗
        ╚══════╝ ╚══▀▀═╝ ╚══════╝";
                string hArt = @"
        ██╗  ██╗████████╗███╗   ███╗██╗     
        ██║  ██║╚══██╔══╝████╗ ████║██║     
        ███████║   ██║   ██╔████╔██║██║     
        ██╔══██║   ██║   ██║╚██╔╝██║██║     
        ██║  ██║   ██║   ██║ ╚═╝ ██║███████╗
        ╚═╝  ╚═╝   ╚═╝   ╚═╝     ╚═╝╚══════╝";
                #endregion

                #region Quiz selection
                Console.WriteLine(@"
┬ ┬┬ ┬┬┌─┐┬ ┬  ┌─┐ ┬ ┬┬┌─┐  ┬ ┬┌─┐┬ ┬┬  ┌┬┐  ┬ ┬┌─┐┬ ┬  ┬  ┬┬┌─┌─┐  ┌┬┐┌─┐  ┌┬┐┌─┐┬┌─┌─┐┌─┐
│││├─┤││  ├─┤  │─┼┐│ ││┌─┘  ││││ ││ ││   ││  └┬┘│ ││ │  │  │├┴┐├┤    │ │ │   │ ├─┤├┴┐├┤  ┌┘
└┴┘┴ ┴┴└─┘┴ ┴  └─┘ └─┘┴└─┘  └┴┘└─┘└─┘┴─┘─┴┘   ┴ └─┘└─┘  ┴─┘┴┴ ┴└─┘   ┴ └─┘   ┴ ┴ ┴┴ ┴└─┘ o ");
                Thread.Sleep(500);
                Console.WriteLine(bArt);
                Thread.Sleep(500);
                Console.WriteLine(jArt);
                Thread.Sleep(500);
                Console.WriteLine(sArt);
                Thread.Sleep(500);
                Console.WriteLine(hArt);

                bool repeat = false;
                string quizType = "";
                do
                {
                    repeat = false;
                    try
                    {
                        quizType = Console.ReadLine().ToLower().Substring(0, 1);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input not understood. Please type Basic, Javascript, SQL, or HTML");
                        repeat = true;
                        throw;
                    }
                } while (repeat);
                #endregion

                #region Quizes
                repeat = false;
                do

                {
                    #region Uh oh catch
                    if (repeat == true)
                    {
                        Console.WriteLine("Basic, Javascript, SQL, or HTML");
                        do
                        {
                            repeat = false;
                            try
                            {
                                quizType = Console.ReadLine().ToLower().Substring(0, 1);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Input not understood. Please type Basic, Javascript, SQL, or HTML");
                                repeat = true;
                                throw;
                            }
                        } while (repeat);
                    }
                    #endregion
                    repeat = false;
                    switch (quizType)
                    {
                        case "b":
                            Basic.Shuffle();
                            #region Basic welcome
                            Console.Clear();
                            Console.WriteLine(@"
╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐
║║║├┤ │  │  │ ││││├┤    │ │ │
╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘" + "\n" + @"
██████╗  █████╗ ███████╗██╗ ██████╗███████╗     ██████╗ ██╗   ██╗██╗███████╗
██╔══██╗██╔══██╗██╔════╝██║██╔════╝██╔════╝    ██╔═══██╗██║   ██║██║╚══███╔╝
██████╔╝███████║███████╗██║██║     ███████╗    ██║   ██║██║   ██║██║  ███╔╝ 
██╔══██╗██╔══██║╚════██║██║██║     ╚════██║    ██║▄▄ ██║██║   ██║██║ ███╔╝  
██████╔╝██║  ██║███████║██║╚██████╗███████║    ╚██████╔╝╚██████╔╝██║███████╗
╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝ ╚═════╝╚══════╝     ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝");
                            foreach (char i in titlepage)
                            {
                                Thread.Sleep(75);
                                Console.Write(i);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            #endregion
                            #region Foreach/Basic Questions
                            foreach (var item in Basic)
                            {
                              
                                Console.WriteLine(@"
╔═╗┬ ┬┬─┐┬─┐┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┌─┐┬─┐┌─┐
║  │ │├┬┘├┬┘├┤ │││ │   ╚═╗│  │ │├┬┘├┤  o
╚═╝└─┘┴└─┴└─└─┘┘└┘ ┴   ╚═╝└─┘└─┘┴└─└─┘ o
" + "\n" + ScoreArt(scoreB) + "\n\n");
                                int Ans = 0;
                                bool milk = false;
                                Console.WriteLine(item);
                                do
                                {
                                    milk = false;
                                    try
                                    {

                                        Ans = Convert.ToInt32(Console.ReadLine().Substring(0, 1));
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Input not understood");
                                        milk = true;
                                    }
                                } while (milk);


                                if (Ans == item.Solution)
                                {
                                    Console.WriteLine("\nCorrect!");
                                    scoreB++;
                                }
                                else
                                {
                                    Console.WriteLine("\nIncorrect. The correct answer is " +
                                        item.Solution + ".");
                                    Wrong.Add(item);
                                }
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            #endregion
                            //TODO ask if wanting to do another quiz stop them repeating quiz w/out clearing score.
                            break;
                        case "j":
                            JQueryJavaScript.Shuffle();
                            #region JS welcome
                            Console.Clear();
                            Console.WriteLine(@"
╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐
║║║├┤ │  │  │ ││││├┤    │ │ │
╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘" + "\n" + @"
     ██╗ █████╗ ██╗   ██╗ █████╗ ███████╗ ██████╗██████╗ ██╗██████╗ ████████╗
     ██║██╔══██╗██║   ██║██╔══██╗██╔════╝██╔════╝██╔══██╗██║██╔══██╗╚══██╔══╝
     ██║███████║██║   ██║███████║███████╗██║     ██████╔╝██║██████╔╝   ██║   
██   ██║██╔══██║╚██╗ ██╔╝██╔══██║╚════██║██║     ██╔══██╗██║██╔═══╝    ██║   
╚█████╔╝██║  ██║ ╚████╔╝ ██║  ██║███████║╚██████╗██║  ██║██║██║        ██║   
 ╚════╝ ╚═╝  ╚═╝  ╚═══╝  ╚═╝  ╚═╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝╚═╝        ╚═╝   
                                                                             
                                                 ██████╗ ██╗   ██╗██╗███████╗
                                                ██╔═══██╗██║   ██║██║╚══███╔╝
                                                ██║   ██║██║   ██║██║  ███╔╝ 
                                                ██║▄▄ ██║██║   ██║██║ ███╔╝  
                                                ╚██████╔╝╚██████╔╝██║███████╗
                                                 ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝
                                                                            " );
                            foreach (char i in titlepage)
                            {
                                Thread.Sleep(75);
                                Console.Write(i);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            #endregion
                            #region Foreach/JS Questions
                            foreach (var item in JQueryJavaScript)
                            {
                               
                                Console.WriteLine(@"
╔═╗┬ ┬┬─┐┬─┐┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┌─┐┬─┐┌─┐
║  │ │├┬┘├┬┘├┤ │││ │   ╚═╗│  │ │├┬┘├┤  o
╚═╝└─┘┴└─┴└─└─┘┘└┘ ┴   ╚═╝└─┘└─┘┴└─└─┘ o
" + "\n" + ScoreArt(scoreJ) + "\n\n");
                                int Ans = 0;
                                bool milk = false;
                                Console.WriteLine(item + "\n");
                                do
                                {
                                    milk = false;
                                    try
                                    {

                                        Ans = Convert.ToInt32(Console.ReadLine().Substring(0, 1));
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Input not understood");
                                        milk = true;
                                    }
                                } while (milk);


                                if (Ans == item.Solution)
                                {
                                    Console.WriteLine("\nCorrect!");
                                    scoreJ++;
                                }
                                else
                                {
                                    Console.WriteLine("\nIncorrect. The correct answer is " +
                                        item.Solution + ".");
                                    Wrong.Add(item);
                                }
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            #endregion
                            Console.WriteLine("Your total score for Javascript is: " + scoreJ + "/" + JQueryJavaScript.Count);
                            break;
                        case "h":
                            HTML_CSS.Shuffle();
                            #region Html/Css welcome
                            Console.Clear();
                            Console.WriteLine(@"
╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐
║║║├┤ │  │  │ ││││├┤    │ │ │
╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘" + "\n" + @"
██╗  ██╗████████╗███╗   ███╗██╗         ██╗ ██████╗███████╗███████╗  
██║  ██║╚══██╔══╝████╗ ████║██║        ██╔╝██╔════╝██╔════╝██╔════╝  
███████║   ██║   ██╔████╔██║██║       ██╔╝ ██║     ███████╗███████╗  
██╔══██║   ██║   ██║╚██╔╝██║██║      ██╔╝  ██║     ╚════██║╚════██║  
██║  ██║   ██║   ██║ ╚═╝ ██║███████╗██╔╝   ╚██████╗███████║███████║  
╚═╝  ╚═╝   ╚═╝   ╚═╝     ╚═╝╚══════╝╚═╝     ╚═════╝╚══════╝╚══════╝  
                                                                     
                                         ██████╗ ██╗   ██╗██╗███████╗
                                        ██╔═══██╗██║   ██║██║╚══███╔╝
                                        ██║   ██║██║   ██║██║  ███╔╝ 
                                        ██║▄▄ ██║██║   ██║██║ ███╔╝  
                                        ╚██████╔╝╚██████╔╝██║███████╗
                                         ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝" + "\n\n");
                            foreach (char i in titlepage)
                            {
                                Thread.Sleep(75);
                                Console.Write(i);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            #endregion
                            #region Foreach/Html/Css Questions
                            foreach (var item in HTML_CSS)
                            {                           
                                Console.WriteLine(@"
╔═╗┬ ┬┬─┐┬─┐┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┌─┐┬─┐┌─┐
║  │ │├┬┘├┬┘├┤ │││ │   ╚═╗│  │ │├┬┘├┤  o
╚═╝└─┘┴└─┴└─└─┘┘└┘ ┴   ╚═╝└─┘└─┘┴└─└─┘ o
" + "\n" + ScoreArt(scoreH) + "\n\n");
                                int Ans = 0;
                                bool milk = false;
                                Console.WriteLine(item + "\n");
                                do
                                {
                                    milk = false;
                                    try
                                    {

                                        Ans = Convert.ToInt32(Console.ReadLine().Substring(0, 1));
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Input not understood");
                                        milk = true;
                                    }
                                } while (milk);


                                if (Ans == item.Solution)
                                {
                                    Console.WriteLine("\nCorrect!");
                                    scoreH++;
                                }
                                else
                                {
                                    Console.WriteLine("\nIncorrect. The correct answer is " +
                                        item.Solution + ".");
                                    Wrong.Add(item);
                                }
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            #endregion
                            repeat = true; 
                            break;
                        case "s":
                            Console.Clear();
                            Console.WriteLine("Sorry no questions yet. Try again.");
                            repeat = true;
                            break;
                        default:
                            Console.WriteLine("Input not understood. Please type Basic, Javascript, SQL, or HTML");
                            repeat = true;
                            break;
                    }
                } while (repeat);
                #endregion
            } while (repeatQuiz);//end ability to repeat quiz


            Console.WriteLine("Congrats your total score is: " + scoreB + "/" + outOF);
            Console.ReadKey();
        }
        public static string ScoreArt(int score)
        {
            string scoreArt = "";
            switch (score)
            {
                #region 1-10
                case 0:
                    scoreArt = @"
         ██████╗ 
        ██╔═████╗
        ██║██╔██║
        ████╔╝██║
        ╚██████╔╝
         ╚═════╝ ";
                    break;
                case 1:
                    scoreArt = @"
         ██╗
        ███║
        ╚██║
         ██║
         ██║
         ╚═╝
            "; break;
                case 2:
                    scoreArt = @"
        ██████╗ 
        ╚════██╗
         █████╔╝
        ██╔═══╝ 
        ███████╗"; break;
                case 3:
                    scoreArt = @"
        ██████╗ 
        ╚════██╗
         █████╔╝
         ╚═══██╗
        ██████╔╝
        ╚═════╝ "; break;
                case 4:
                    scoreArt = @"
        ██╗  ██╗
        ██║  ██║
        ███████║
        ╚════██║
             ██║
             ╚═╝"; break;
                case 5:
                    scoreArt = @"
        ███████╗
        ██╔════╝
        ███████╗
        ╚════██║
        ███████║
        ╚══════╝";
                    break;
                case 6:
                    scoreArt = @"
         ██████╗ 
        ██╔════╝ 
        ███████╗ 
        ██╔═══██╗
        ╚██████╔╝
         ╚═════╝ "; break;
                case 7:
                    scoreArt = @"
        ███████╗
        ╚════██║
            ██╔╝
           ██╔╝ 
           ██║  
           ╚═╝  "; break;
                case 8:
                    scoreArt = @" 
        █████╗ 
        ██╔══██╗
        ╚█████╔╝
        ██╔══██╗
        ╚█████╔╝
         ╚════╝ 
                "; break;
                case 9:
                    scoreArt = @"
         █████╗ 
        ██╔══██╗
        ╚██████║
         ╚═══██║
         █████╔╝
         ╚════╝ "; break;
                case 10:
                    scoreArt = @"
         ██╗ ██████╗ 
        ███║██╔═████╗
        ╚██║██║██╔██║
         ██║████╔╝██║
         ██║╚██████╔╝
         ╚═╝ ╚═════╝ 
                     "; break;
                #endregion
                #region 11-20
                case 11:
                    scoreArt = @"
         ██╗ ██╗
        ███║███║
        ╚██║╚██║
         ██║ ██║
         ██║ ██║
         ╚═╝ ╚═╝"; break;
                case 12:
                    scoreArt = @"
         ██╗██████╗ 
        ███║╚════██╗
        ╚██║ █████╔╝
         ██║██╔═══╝ 
         ██║███████╗
         ╚═╝╚══════╝"; break;
                case 13:
                    scoreArt = @"
         ██╗██████╗ 
        ███║╚════██╗
        ╚██║ █████╔╝
         ██║ ╚═══██╗
         ██║██████╔╝
         ╚═╝╚═════╝   "; break;
                case 14:
                    scoreArt = @"
         ██╗██╗  ██╗
        ███║██║  ██║
        ╚██║███████║
         ██║╚════██║
         ██║     ██║
         ╚═╝     ╚═╝"; break;
                case 15:
                    scoreArt = @"
         ██╗███████╗
        ███║██╔════╝
        ╚██║███████╗
         ██║╚════██║
         ██║███████║
         ╚═╝╚══════╝"; break;
                case 16:
                    scoreArt = @"
         ██╗ ██████╗ 
        ███║██╔════╝ 
        ╚██║███████╗ 
         ██║██╔═══██╗
         ██║╚██████╔╝
         ╚═╝ ╚═════╝"; break;
                case 17:
                    scoreArt = @"
         ██╗███████╗
        ███║╚════██║
        ╚██║    ██╔╝
         ██║   ██╔╝ 
         ██║   ██║  
         ╚═╝   ╚═╝"; break;
                case 18:
                    scoreArt = @"
         ██╗ █████╗ 
        ███║██╔══██╗
        ╚██║╚█████╔╝
         ██║██╔══██╗
         ██║╚█████╔╝
         ╚═╝ ╚════╝"; break;
                case 19:
                    scoreArt = @"
         ██╗ █████╗ 
        ███║██╔══██╗
        ╚██║╚██████║
         ██║ ╚═══██║
         ██║ █████╔╝
         ╚═╝ ╚════╝ "; break;
                case 20:
                    scoreArt = @"
        ██████╗  ██████╗ 
        ╚════██╗██╔═████╗
         █████╔╝██║██╔██║
        ██╔═══╝ ████╔╝██║
        ███████╗╚██████╔╝
        ╚══════╝ ╚═════╝ "; break;
                #endregion
                #region 21-30
                case 21:
                    scoreArt = @"
        ██████╗   ██╗ 
        ╚════██╗ ███║
         █████╔╝ ╚██║
        ██╔═══╝   ██║ 
        ███████╗  ██║
        ╚══════╝  ╚═╝ "; break;
                case 22:
                    scoreArt = @"
        ██████╗ ██████╗ 
        ╚════██╗╚════██╗
         █████╔╝ █████╔╝
        ██╔═══╝ ██╔═══╝ 
        ███████╗███████╗
        ╚══════╝╚══════╝"; break;
                case 23:
                    scoreArt = @"
        ██████╗ ██████╗ 
        ╚════██╗╚════██╗
         █████╔╝ █████╔╝
        ██╔═══╝  ╚═══██╗
        ███████╗██████╔╝
        ╚══════╝╚═════╝ "; break;
                case 24:
                    scoreArt = @"
        ██████╗ ██╗  ██╗
        ╚════██╗██║  ██║
         █████╔╝███████║
        ██╔═══╝ ╚════██║
        ███████╗     ██║
        ╚══════╝     ╚═╝"; break;
                case 25:
                    scoreArt = @"
        ██████╗ ███████╗
        ╚════██╗██╔════╝
         █████╔╝███████╗
        ██╔═══╝ ╚════██║
        ███████╗███████║
        ╚══════╝╚══════╝"; break;
                case 26:
                    scoreArt = @"
        ██████╗  ██████╗ 
        ╚════██╗██╔════╝ 
         █████╔╝███████╗ 
        ██╔═══╝ ██╔═══██╗
        ███████╗╚██████╔╝
        ╚══════╝ ╚═════╝ "; break;
                case 27:
                    scoreArt = @"
        ██████╗ ███████╗
        ╚════██╗╚════██║
         █████╔╝    ██╔╝
        ██╔═══╝    ██╔╝ 
        ███████╗   ██║  
        ╚══════╝   ╚═╝  "; break;
                case 28:
                    scoreArt = @"
        ██████╗  █████╗ 
        ╚════██╗██╔══██╗
         █████╔╝╚█████╔╝
        ██╔═══╝ ██╔══██╗
        ███████╗╚█████╔╝
        ╚══════╝ ╚════╝ "; break;
                case 29:
                    scoreArt = @"
        ██████╗  █████╗ 
        ╚════██╗██╔══██╗
         █████╔╝╚██████║
        ██╔═══╝  ╚═══██║
        ███████╗ █████╔╝
        ╚══════╝ ╚════╝ 
                        "; break;
                case 30:
                    scoreArt = @"
        ██████╗  ██████╗ 
        ╚════██╗██╔═████╗
         █████╔╝██║██╔██║
         ╚═══██╗████╔╝██║
        ██████╔╝╚██████╔╝
        ╚═════╝  ╚═════╝ 
                         "; break;
                #endregion
                #region 31-40
                case 31:
                    scoreArt = @"
        ██████╗  ██╗
        ╚════██╗███║
         █████╔╝╚██║
         ╚═══██╗ ██║
        ██████╔╝ ██║
        ╚═════╝  ╚═╝"; break;
                case 32:
                    scoreArt = @"
        ██████╗ ██████╗ 
        ╚════██╗╚════██╗
         █████╔╝ █████╔╝
         ╚═══██╗██╔═══╝ 
        ██████╔╝███████╗
        ╚═════╝ ╚══════╝"; break;
                case 33:
                    scoreArt = @"
        ██████╗ ██████╗ 
        ╚════██╗╚════██╗
         █████╔╝ █████╔╝
         ╚═══██╗ ╚═══██╗
        ██████╔╝██████╔╝
        ╚═════╝ ╚═════╝ "; break;
                case 34:
                    scoreArt = @"
        ██████╗ ██╗  ██╗
        ╚════██╗██║  ██║
         █████╔╝███████║
         ╚═══██╗╚════██║
        ██████╔╝     ██║
        ╚═════╝      ╚═╝"; break;
                case 35:
                    scoreArt = @"
        ██████╗ ███████╗
        ╚════██╗██╔════╝
         █████╔╝███████╗
         ╚═══██╗╚════██║
        ██████╔╝███████║
        ╚═════╝ ╚══════╝"; break;
                case 36:
                    scoreArt = @"
        ██████╗  ██████╗ 
        ╚════██╗██╔════╝ 
         █████╔╝███████╗ 
         ╚═══██╗██╔═══██╗
        ██████╔╝╚██████╔╝
        ╚═════╝  ╚═════╝ "; break;
                case 37:
                    scoreArt = @"
        ██████╗ ███████╗
        ╚════██╗╚════██║
         █████╔╝    ██╔╝
         ╚═══██╗   ██╔╝ 
        ██████╔╝   ██║  
        ╚═════╝    ╚═╝  "; break;
                case 38:
                    scoreArt = @"
        ██████╗  █████╗ 
        ╚════██╗██╔══██╗
         █████╔╝╚█████╔╝
         ╚═══██╗██╔══██╗
        ██████╔╝╚█████╔╝
        ╚═════╝  ╚════╝ "; break;
                case 39:
                    scoreArt = @"
        ██████╗  █████╗ 
        ╚════██╗██╔══██╗
         █████╔╝╚██████║
         ╚═══██╗ ╚═══██║
        ██████╔╝ █████╔╝
        ╚═════╝  ╚════╝ "; break;
                case 40:
                    scoreArt = @"
        ██╗  ██╗ ██████╗ 
        ██║  ██║██╔═████╗
        ███████║██║██╔██║
        ╚════██║████╔╝██║
             ██║╚██████╔╝
             ╚═╝ ╚═════╝ "; break;
                #endregion
                #region 41-50
                case 41:
                    scoreArt = @"
        ██╗  ██╗ ██╗
        ██║  ██║███║
        ███████║╚██║
        ╚════██║ ██║
             ██║ ██║
             ╚═╝ ╚═╝"; break;
                case 42:
                    scoreArt = @"
        ██╗  ██╗██████╗ 
        ██║  ██║╚════██╗
        ███████║ █████╔╝
        ╚════██║██╔═══╝ 
             ██║███████╗
             ╚═╝╚══════╝"; break;
                case 43:
                    scoreArt = @"
        ██╗  ██╗██████╗ 
        ██║  ██║╚════██╗
        ███████║ █████╔╝
        ╚════██║ ╚═══██╗
             ██║██████╔╝
             ╚═╝╚═════╝ "; break;
                case 44:
                    scoreArt = @"
        ██╗  ██╗██╗  ██╗
        ██║  ██║██║  ██║
        ███████║███████║
        ╚════██║╚════██║
             ██║     ██║
             ╚═╝     ╚═╝"; break;
                case 45:
                    scoreArt = @"
        ██╗  ██╗███████╗
        ██║  ██║██╔════╝
        ███████║███████╗
        ╚════██║╚════██║
             ██║███████║
             ╚═╝╚══════╝"; break;
                case 46:
                    scoreArt = @"
        ██╗  ██╗ ██████╗ 
        ██║  ██║██╔════╝ 
        ███████║███████╗ 
        ╚════██║██╔═══██╗
             ██║╚██████╔╝
             ╚═╝ ╚═════╝ "; break;
                case 47:
                    scoreArt = @"
        ██╗  ██╗███████╗
        ██║  ██║╚════██║
        ███████║    ██╔╝
        ╚════██║   ██╔╝ 
             ██║   ██║  
             ╚═╝   ╚═╝  "; break;
                case 48:
                    scoreArt = @"
        ██╗  ██╗ █████╗ 
        ██║  ██║██╔══██╗
        ███████║╚█████╔╝
        ╚════██║██╔══██╗
             ██║╚█████╔╝
             ╚═╝ ╚════╝ "; break;
                case 49:
                    scoreArt = @"
        ██╗  ██╗ █████╗ 
        ██║  ██║██╔══██╗
        ███████║╚██████║
        ╚════██║ ╚═══██║
             ██║ █████╔╝
             ╚═╝ ╚════╝ "; break;
                case 50:
                    scoreArt = @"
        ███████╗ ██████╗ 
        ██╔════╝██╔═████╗
        ███████╗██║██╔██║
        ╚════██║████╔╝██║
        ███████║╚██████╔╝
        ╚══════╝ ╚═════╝"; break;
                #endregion
                #region 51-60
                case 51:
                    scoreArt = @"
        ███████╗ ██╗
        ██╔════╝███║
        ███████╗╚██║
        ╚════██║ ██║
        ███████║ ██║
        ╚══════╝ ╚═╝"; break;
                case 52:
                    scoreArt = @"
        ███████╗██████╗ 
        ██╔════╝╚════██╗
        ███████╗ █████╔╝
        ╚════██║██╔═══╝ 
        ███████║███████╗
        ╚══════╝╚══════╝
                        "; break;
                case 53:
                    scoreArt = @"
        ███████╗██████╗ 
        ██╔════╝╚════██╗
        ███████╗ █████╔╝
        ╚════██║ ╚═══██╗
        ███████║██████╔╝
        ╚══════╝╚═════╝ "; break;
                case 54:
                    scoreArt = @"
        ███████╗██╗  ██╗
        ██╔════╝██║  ██║
        ███████╗███████║
        ╚════██║╚════██║
        ███████║     ██║
        ╚══════╝     ╚═╝"; break;
                case 55:
                    scoreArt = @"
        ███████╗███████╗
        ██╔════╝██╔════╝
        ███████╗███████╗
        ╚════██║╚════██║
        ███████║███████║
        ╚══════╝╚══════╝"; break;
                case 56:
                    scoreArt = @"
        ███████╗ ██████╗ 
        ██╔════╝██╔════╝ 
        ███████╗███████╗ 
        ╚════██║██╔═══██╗
        ███████║╚██████╔╝
        ╚══════╝ ╚═════╝ "; break;
                case 57:
                    scoreArt = @"
        ███████╗███████╗
        ██╔════╝╚════██║
        ███████╗    ██╔╝
        ╚════██║   ██╔╝ 
        ███████║   ██║  
        ╚══════╝   ╚═╝  "; break;
                case 58:
                    scoreArt = @"
        ███████╗ █████╗ 
        ██╔════╝██╔══██╗
        ███████╗╚█████╔╝
        ╚════██║██╔══██╗
        ███████║╚█████╔╝
        ╚══════╝ ╚════╝ "; break;
                case 59:
                    scoreArt = @"
        ███████╗ █████╗ 
        ██╔════╝██╔══██╗
        ███████╗╚██████║
        ╚════██║ ╚═══██║
        ███████║ █████╔╝
        ╚══════╝ ╚════╝ "; break;
                case 60:
                    scoreArt = @"
         ██████╗  ██████╗ 
        ██╔════╝ ██╔═████╗
        ███████╗ ██║██╔██║
        ██╔═══██╗████╔╝██║
        ╚██████╔╝╚██████╔╝
         ╚═════╝  ╚═════╝ "; break;
                #endregion
                #region 61-70
                case 61:
                    scoreArt = @"
         ██████╗ ██╗
        ██╔════╝███║
        ███████╗╚██║
        ██╔═══██╗██║
        ╚██████╔╝██║
         ╚═════╝ ╚═╝"; break;
                case 62:
                    scoreArt = @"
         ██████╗ ██████╗ 
        ██╔════╝ ╚════██╗
        ███████╗  █████╔╝
        ██╔═══██╗██╔═══╝ 
        ╚██████╔╝███████╗
         ╚═════╝ ╚══════╝"; break;
                case 63:
                    scoreArt = @"
         ██████╗ ██████╗ 
        ██╔════╝ ╚════██╗
        ███████╗  █████╔╝
        ██╔═══██╗ ╚═══██╗
        ╚██████╔╝██████╔╝
         ╚═════╝ ╚═════╝ "; break;
                case 64:
                    scoreArt = @"
         ██████╗ ██╗  ██╗
        ██╔════╝ ██║  ██║
        ███████╗ ███████║
        ██╔═══██╗╚════██║
        ╚██████╔╝     ██║
         ╚═════╝      ╚═╝"; break;
                case 65:
                    scoreArt = @"
         ██████╗ ███████╗
        ██╔════╝ ██╔════╝
        ███████╗ ███████╗
        ██╔═══██╗╚════██║
        ╚██████╔╝███████║
         ╚═════╝ ╚══════╝"; break;
                case 66:
                    scoreArt = @"
         ██████╗  ██████╗ 
        ██╔════╝ ██╔════╝ 
        ███████╗ ███████╗ 
        ██╔═══██╗██╔═══██╗
        ╚██████╔╝╚██████╔╝
         ╚═════╝  ╚═════╝ "; break;
                case 67:
                    scoreArt = @"
         ██████╗███████╗
        ██╔════╝╚════██║
        ███████╗    ██╔╝
        ██╔═══██╗  ██╔╝ 
        ╚██████╔╝  ██║  
         ╚═════╝   ╚═╝  "; break;
                case 68:
                    scoreArt = @"
         ██████╗  █████╗ 
        ██╔════╝ ██╔══██╗
        ███████╗ ╚█████╔╝
        ██╔═══██╗██╔══██╗
        ╚██████╔╝╚█████╔╝
         ╚═════╝  ╚════╝ 
                         "; break;
                case 69:
                    scoreArt = @"
         ██████╗ █████╗ 
        ██╔════╝██╔══██╗
        ███████╗╚██████║
        ██╔═══██╗╚═══██║
        ╚██████╔╝█████╔╝
         ╚═════╝ ╚════╝ "; break;
                case 70:
                    scoreArt = @"
        ███████╗ ██████╗ 
        ╚════██║██╔═████╗
            ██╔╝██║██╔██║
           ██╔╝ ████╔╝██║
           ██║  ╚██████╔╝
           ╚═╝   ╚═════╝ "; break;
                #endregion
                #region 71-80
                case 71:
                    scoreArt = @"
        ███████╗ ██╗
        ╚════██║███║
            ██╔╝╚██║
           ██╔╝  ██║
           ██║   ██║
           ╚═╝   ╚═╝"; break;
                case 72:
                    scoreArt = @"
        ███████╗██████╗ 
        ╚════██║╚════██╗
            ██╔╝ █████╔╝
           ██╔╝ ██╔═══╝ 
           ██║  ███████╗
           ╚═╝  ╚══════╝"; break;
                case 73:
                    scoreArt = @"
        ███████╗██████╗ 
        ╚════██║╚════██╗
            ██╔╝ █████╔╝
           ██╔╝  ╚═══██╗
           ██║  ██████╔╝
           ╚═╝  ╚═════╝ "; break;
                case 74:
                    scoreArt = @"
        ███████╗██╗  ██╗
        ╚════██║██║  ██║
            ██╔╝███████║
           ██╔╝ ╚════██║
           ██║       ██║
           ╚═╝       ╚═╝"; break;
                case 75:
                    scoreArt = @"
        ███████╗███████╗
        ╚════██║██╔════╝
            ██╔╝███████╗
           ██╔╝ ╚════██║
           ██║  ███████║
           ╚═╝  ╚══════╝"; break;
                case 76:
                    scoreArt = @"
        ███████╗ ██████╗ 
        ╚════██║██╔════╝ 
            ██╔╝███████╗ 
           ██╔╝ ██╔═══██╗
           ██║  ╚██████╔╝
           ╚═╝   ╚═════╝"; break;
                case 77:
                    scoreArt = @"
        ███████╗███████╗
        ╚════██║╚════██║
            ██╔╝    ██╔╝
           ██╔╝    ██╔╝ 
           ██║     ██║  
           ╚═╝     ╚═╝  "; break;
                case 78:
                    scoreArt = @"
        ███████╗ █████╗ 
        ╚════██║██╔══██╗
            ██╔╝╚█████╔╝
           ██╔╝ ██╔══██╗
           ██║  ╚█████╔╝
           ╚═╝   ╚════╝ "; break;
                case 79:
                    scoreArt = @"
        ███████╗ █████╗ 
        ╚════██║██╔══██╗
            ██╔╝╚██████║
           ██╔╝  ╚═══██║
           ██║   █████╔╝
           ╚═╝   ╚════╝ "; break;
                case 80:
                    scoreArt = @"
         █████╗  ██████╗ 
        ██╔══██╗██╔═████╗
        ╚█████╔╝██║██╔██║
        ██╔══██╗████╔╝██║
        ╚█████╔╝╚██████╔╝
         ╚════╝  ╚═════╝"; break;
                #endregion
                #region 81-90
                case 81:
                    scoreArt = @"
         █████╗  ██╗
        ██╔══██╗███║
        ╚█████╔╝╚██║
        ██╔══██╗ ██║
        ╚█████╔╝ ██║
         ╚════╝  ╚═╝"; break;
                case 82:
                    scoreArt = @"
         █████╗ ██████╗ 
        ██╔══██╗╚════██╗
        ╚█████╔╝ █████╔╝
        ██╔══██╗██╔═══╝ 
        ╚█████╔╝███████╗
         ╚════╝ ╚══════╝"; break;
                case 83:
                    scoreArt = @"
         █████╗ ██████╗ 
        ██╔══██╗╚════██╗
        ╚█████╔╝ █████╔╝
        ██╔══██╗ ╚═══██╗
        ╚█████╔╝██████╔╝
         ╚════╝ ╚═════╝"; break;
                case 84:
                    scoreArt = @"
         █████╗ ██╗  ██╗
        ██╔══██╗██║  ██║
        ╚█████╔╝███████║
        ██╔══██╗╚════██║
        ╚█████╔╝     ██║
         ╚════╝      ╚═╝"; break;
                case 85:
                    scoreArt = @"
         █████╗ ███████╗
        ██╔══██╗██╔════╝
        ╚█████╔╝███████╗
        ██╔══██╗╚════██║
        ╚█████╔╝███████║
         ╚════╝ ╚══════╝"; break;
                case 86:
                    scoreArt = @"
         █████╗  ██████╗ 
        ██╔══██╗██╔════╝ 
        ╚█████╔╝███████╗ 
        ██╔══██╗██╔═══██╗
        ╚█████╔╝╚██████╔╝
         ╚════╝  ╚═════╝ "; break;
                case 87:
                    scoreArt = @"
         █████╗ ███████╗
        ██╔══██╗╚════██║
        ╚█████╔╝    ██╔╝
        ██╔══██╗   ██╔╝ 
        ╚█████╔╝   ██║  
         ╚════╝    ╚═╝  "; break;
                case 88:
                    scoreArt = @"
         █████╗  █████╗ 
        ██╔══██╗██╔══██╗
        ╚█████╔╝╚█████╔╝
        ██╔══██╗██╔══██╗
        ╚█████╔╝╚█████╔╝
         ╚════╝  ╚════╝"; break;
                case 89:
                    scoreArt = @"
         █████╗  █████╗ 
        ██╔══██╗██╔══██╗
        ╚█████╔╝╚██████║
        ██╔══██╗ ╚═══██║
        ╚█████╔╝ █████╔╝
         ╚════╝  ╚════╝ "; break;
                case 90:
                    scoreArt = @"
         █████╗  ██████╗ 
        ██╔══██╗██╔═████╗
        ╚██████║██║██╔██║
         ╚═══██║████╔╝██║
         █████╔╝╚██████╔╝
         ╚════╝  ╚═════╝ "; break;
                #endregion
                #region 91-100
                case 91:
                    scoreArt = @"
         █████╗  ██╗
        ██╔══██╗███║
        ╚██████║╚██║
         ╚═══██║ ██║
         █████╔╝ ██║
         ╚════╝  ╚═╝"; break;
                case 92:
                    scoreArt = @"
         █████╗ ██████╗ 
        ██╔══██╗╚════██╗
        ╚██████║ █████╔╝
         ╚═══██║██╔═══╝ 
         █████╔╝███████╗
         ╚════╝ ╚══════╝"; break;
                case 93:
                    scoreArt = @"
         █████╗ ██████╗ 
        ██╔══██╗╚════██╗
        ╚██████║ █████╔╝
         ╚═══██║ ╚═══██╗
         █████╔╝██████╔╝
         ╚════╝ ╚═════╝ "; break;
                case 94:
                    scoreArt = @"
         █████╗ ██╗  ██╗
        ██╔══██╗██║  ██║
        ╚██████║███████║
         ╚═══██║╚════██║
         █████╔╝     ██║
         ╚════╝      ╚═╝"; break;
                case 95:
                    scoreArt = @"
         █████╗ ███████╗
        ██╔══██╗██╔════╝
        ╚██████║███████╗
         ╚═══██║╚════██║
         █████╔╝███████║
         ╚════╝ ╚══════╝"; break;
                case 96:
                    scoreArt = @"
         █████╗  ██████╗ 
        ██╔══██╗██╔════╝ 
        ╚██████║███████╗ 
         ╚═══██║██╔═══██╗
         █████╔╝╚██████╔╝
         ╚════╝  ╚═════╝ "; break;
                case 97:
                    scoreArt = @"
         █████╗ ███████╗
        ██╔══██╗╚════██║
        ╚██████║    ██╔╝
         ╚═══██║   ██╔╝ 
         █████╔╝   ██║  
         ╚════╝    ╚═╝ "; break;
                case 98:
                    scoreArt = @"
         █████╗  █████╗ 
        ██╔══██╗██╔══██╗
        ╚██████║╚█████╔╝
         ╚═══██║██╔══██╗
         █████╔╝╚█████╔╝
         ╚════╝  ╚════╝ "; break;
                case 99:
                    scoreArt = @"
         █████╗  █████╗ 
        ██╔══██╗██╔══██╗
        ╚██████║╚██████║
         ╚═══██║ ╚═══██║
         █████╔╝ █████╔╝
         ╚════╝  ╚════╝ "; break;
                case 100:
                    scoreArt = @"
         ██╗ ██████╗  ██████╗ 
        ███║██╔═████╗██╔═████╗
        ╚██║██║██╔██║██║██╔██║
         ██║████╔╝██║████╔╝██║
         ██║╚██████╔╝╚██████╔╝
         ╚═╝ ╚═════╝  ╚═════╝ 
                              "; break;
                #endregion
                default:
                    break;
            }
            return scoreArt;
        }

    

}
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }
    public static class MyExtensions
    {

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

       

    }


        
}
