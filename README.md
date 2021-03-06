Denver Street Sweeping API
=====================

[![Build Status][build_png]][travis]

[build_png]: https://travis-ci.org/codeforamerica/denver-schedules-api.png?branch=master
[travis]: https://travis-ci.org/codeforamerica/denver-schedules-api

*Current Status*: As of October 2014 Denver Street Sweeping is available on [http://streetsweep.co/][ss] as a pilot project for the City and County of Denver. 

* [What is Denver Street Sweeping](#what-is-denver-street-sweeping)
* [Technical details and developer documentation](#technical-details)
* [License](#license)

This is the repo for Denver Street Sweeping's Backend API. If you're looking for the front-end client code, [visit this url][client].

[ss]: http://streetsweep.co
[client]: https://github.com/codeforamerica/denver-schedules

##What Is Denver Street Sweeping?

Denver Street Sweeping is a web application developed by the 2014 Code for America Fellows in Denver. The app uses Street Sweeping data from the City and County of Denver. It allows residents of Denver to lookup an address and find the corresponding street sweeping schedule for that address. The resident can then sign up for schedule reminders by Email or SMS. The web app is responsive.

[Read more about Denver Street Sweeping here](/docs/about.md)


##Technical Details

The Denver Street Sweeping API reads and parses the street sweeping data from the City and County of Denver.

**Languages**: C#, Ruby (Ruby is used for build tools. It isn't necessary but helpful. To get help with Ruby, use [this guide][howto])

[howto]: https://github.com/codeforamerica/howto/blob/master/Ruby.md

### Platform pieces
* [Heroku][heroku] is used for hosting the app.
* [Travis CI][travisci] is used for continuous integration service. 

[heroku]: http://heroku.com
[travisci]: https://travis-ci.org/

### Libraries
* [Nancy][nancy] is the web framework for the API.
* [Dapper][dapper] is a mini-object operational mapper for the API.
* [Simpler][simpler] is a command pattern library for the API.

[nancy]: http://nancyfx.org/
[dapper]: https://github.com/StackExchange/dapper-dot-net
[simpler]: https://github.com/gregoryjscott/Simpler

### Service Dependencies
* [Twilio][twilio] is used to send SMS reminders.
* [Mandrill][mandrill] is used to send Email reminders.

[twilio]: https://www.twilio.com/try-twilio
[mandrill]: https://mandrill.com/signup/

### Contributing ###
See the [Contributing][contributing] for details.
[contributing]: Contributing.md
##License
See the [LICENSE][] for details.

[license]: https://github.com/codeforamerica/denver-schedules-api/blob/master/LICENSE
