//delete default .js script

var EnemyHealth : int = 10; //2 shots on the Enemy, and the Enemy should disappear

function DeductPoints(DamageAmount : int) {
    EnemyHealth -= DamageAmount; //deduct DamageAmount from EnemyHealth
}

    function Update() {
        if(EnemyHealth <= 0) {
            Destroy(gameObject); //destroys the specified gameObject
        }
    }