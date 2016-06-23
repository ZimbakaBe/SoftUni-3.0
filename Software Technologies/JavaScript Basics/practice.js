                                            // CHAPTER 4 - FUNCTIONS//
//Method invocation pattern
    // Create myObject. It has a value and an increment
    // method. The increment method takes an optional
    // parameter. If the argument is not a number, then 1
    // is used as the default.
    var myObject = {
        value: 0,
        increment: function (inc) {
            this.value += typeof inc === 'number' ? inc : 1;
        }
    };
    myObject.increment( );
    document.writeln(myObject.value); // 1
    myObject.increment(2);
    document.writeln(myObject.value); // 3

//Function invocation patter
    // Augment myObject with a double method.
    myObject.double = function ( ) {
        var that = this; // Workaround.
        var helper = function ( ) {
            that.value = add(that.value, that.value);
        };
        helper( ); // Invoke helper as a function.
    };
    // Invoke double as a method.
    myObject.double( );
    document.writeln(myObject.getValue( )); // 6

//Constructor invocation pattern - not a good practice
    var Quo = function(string) {
        this.status = string;
    };

    Quo.prototype.get_status = function() {
        return this.status;
    };

    var myQuo = new Quo('confused');

    console.log(myQuo.get_status());

//Apply Invocation Pattern
    // Make an array of 2 numbers and add them.
    var array = [3, 4];
    var sum = add.apply(null, array); // sum is 7
    // Make an object with a status member.
    var statusObject = {
        status: 'A-OK'
    };
    // statusObject does not inherit from Quo.prototype,
    // but we can invoke the get_status method on
    // statusObject even though statusObject does not have
    // a get_status method.
    var status = Quo.prototype.get_status.apply(statusObject);
    // status is 'A-OK'
