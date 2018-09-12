var fib = function(n) {
    var x = 0;
    var y = 1;
    if (n <= 2)
    {
        return n-1;
    }
    for(var i=0; i < n; i++)
    {
        var tempY = y;
        y = tempY + x;
        x = tempY;
    }
    return y;
}