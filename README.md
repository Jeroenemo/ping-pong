# Ping-Pong (aka Fizz-Buzz)

## Authors
* Mostly Jeroen van Seeters and Mikey Kriegel
* Specs and README composed by Tyler Sinks

## Created
_22 February, 2021_

## Description
* a very early exploration into the C# ("see sharp") programming language ecosphere
* ultimately this is a take on the ubiquitous "FizzBuzz" prompt
* for detailed expectations of the method's behavior, see the test specifications ("Specs")

## Specs
| Expect statement (English) | Input | Output |
| :------------------------ | -----: | :------ |
| Returns all integers from 1 up to and including the user input number | 7 | 1, 2, 3, 4, 5, 6, 7 |
| Returns all numbers divisible by 3 replaced with "ping" | 7 | 1, 2, "ping", 4, 5, "ping", 7 |
| Returns all numbers divisible by 5 replaced with "pong" | 7 | 1, 2, "ping", 4, "pong", "ping", 7 |
| Returns numbers divisble by both 3 and 5 replaced with "ping-pong" | 17 | 1, 2, "ping", 4, "pong", "ping", 7, 8, "ping", "pong", 11, "ping", 13, 14, "ping-pong", 16, 17 |

## Technologies Used
* _C#, dotnet scripts_
* _.Net CORE version 5.0.100_
* _VS Code (and its built-in terminal / z-shell)_

## **Installation Instructions to Setup This Project on Your Machine**
* Copy the following link to your clipboard: https://github.com/sinkstyt/ping-pong.git
* Open a Bash Terminal (often also called 'the command line')
* In this terminal window, navigate to a directory into which you will clone this project
* _(ie. bring a copy of the entire reposity down to your machine from GitHub's remote repository)_
>  **Example:**
```
~ $ pwd
~/
$ mkdir pingpong
$ cd pingpong
```
* Within your terminal type in 'git clone ' and then paste in the link from your clipboard by right clicking and selecting 'paste' example below:
> at Terminal promt
```
~/pingpong $ git clone https://github.com/sinkstyt/pingpong.git
```
* Press <kbd>ENTER<kbd>
* After the page has been cloned to your chosen directory, use `$ cd ping-pong` to switch into its root folder.
* Launch all the files in your text editor of choice (such as VS Code, Atom, Sublime, VIM, etc.)
* If configured, use `$ code .` to open the entire repository in VS Code
* From the command line within VS Code, you can call the following to test the solution:
>  `$ dotnet run`

## Known Bugs

* _No known bugs_
* _Note that the application is utterly simple_

## License
MIT 2.0

## Contact Information
* [Contact Tyler](mailto:tyler.sinks@gmail.com)
* [Go to Mikey's GitHub profile](https://github.com/mikkrieg)
* [Go to Jeroen's GitHub profile](https://github.com/Jeroenemo)