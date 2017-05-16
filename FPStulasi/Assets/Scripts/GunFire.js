function Update() { //this function runs constantly
    if (Input.GetButtonDown("Fire1")) { //left mouse button to fire the gun
        var gunsound : AudioSource = GetComponent.<AudioSource>(); //gunsound variable is created
        gunsound.Play();
        GetComponent.<Animation>().Play("GunShot");
    }
}