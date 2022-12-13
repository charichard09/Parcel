# _Project Name_

#### By _**Richard Cha**_

#### _Choose from Pastry or Bread, give amount, and return total cost_

## Technologies Used

* _C#_
* _.Net 6_
* _MSTest_
* _ASP.NET Core 6 MVC_

## Description

Following the guidelines below, create a website for a fictional shipping company that helps users calculate shipping estimates:

* Create a Parcel class and test it thoroughly. It should contain a constructor, and getters and setters for each property. You should be able to create a new parcel and specify the dimensions and weight in the arguments.

* Create a website where the user can submit a form with the dimensions and weight of a Parcel, and you can use the data in the form to instantiate a Parcel object and display its dimensions and weight.

* When you call a method called Volume() on a Parcel instance, it should return the product of the sides.

* When you call a CostToShip() method on your parcel, return a cost based on a formula you make up.

* Display the cost to ship and the volume of a Parcel with its dimensions in your site.

* **Bonus**: Add validation and make sure the Parcel object is not created if any of the form fields are blank. Display an error message instead. Also make sure your user can only enter numbers into the form.

_This application will prompt the user to enter if they'd like to add Bread or Pastry to Cart then how many to add to Cart. It will then give the prompt an option to add more as a yes or no._
_If the user is done adding items to the cart, the program will display their cart and a Cart Total._

## Setup/Installation Requirements

* _Install .Net 6 SDK:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* _Clone this repo to a local directory_
* _Using Terminal on OS X or PowerShell on Windows navigate to the top directory that this repo was cloned to (YourPath/PierresBakery.Solution):_ 
* _Confirm all business logic tests pass with MSTest by running commands (not including the dollar symbol):_
* _$ dotnet restore ./PierresBakery.Tests_
* _$ dotnet test ./PierresBakery.Tests_
* _Then run the program with command :_
* _$ dotnet run --project PierresBakery_

## Known Bugs

* _None_

## License

_If you have any issues or have questions, ideas or concerns please contact me at [charichard09@gmail.com](mailto:charichard09@gmail.com)_

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _12-09-22_ _Richard Cha_