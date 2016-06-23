function threeIntegersSum(arr) {

    console.log(check(arr[0], arr[1], arr[2]));

    function check(num1, num2, num3) {

        if (Number(num1) + Number(num2) === Number(num3) ||
            Number(num1) + Number(num3) === Number(num2) ||
            Number(num2) + Number(num3) === Number(num1)) {
            return true;
        } else {
            return false;
        }
    }
}

threeIntegersSum(['8', '15', '7']);
