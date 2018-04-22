<?php
session_start();
$host  = $_SERVER['HTTP_HOST'];
$uri   = rtrim(dirname($_SERVER['PHP_SELF']), '/\\');


$name = isset($_POST['userid']) ? $_POST['userid'] : '';
$passwort_aktuell = isset($_POST['pwd']) ? $_POST['pwd'] : '';
$ch1 = curl_init();

//need to encrypt the password later
$options = [
    'cost' => 12,
];
$passwordcrypt = password_hash($passwort_aktuell, PASSWORD_BCRYPT,$options);

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/login?username=$name&password=$passwort_aktuell");
//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/login?username=$name&password=$passwort_aktuell");
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$login = curl_exec( $ch1 );
curl_close( $ch1 );

// Unwandlung von json in Array	
$jsonlogin = json_decode($login, TRUE);


//für den echten Einsatz Passwörter nicht im Klartext speichern!
$benutzer = [
    'admin' => '12345',
    'manu' => '6789',
    'merlin' => 'asdfg'
];


if($login==true)
{
	$extra = 'usercontent.php';
    $_SESSION['login'] = 'ok';
    $_SESSION['name'] = $name;
}
else
{
	$extra = 'start.php?f=1';
}

header("Location: http://$host$uri/$extra/$jsonlogin");

//if (!array_key_exists($name, $benutzer)) {
//    $extra = 'start.php?f=1';
//} elseif ($benutzer[$name] != $passwort_aktuell) {
//    $extra = 'start.php?f=2';

//} else {
//    $extra = 'usercontent.php';
//    $_SESSION['login'] = 'ok';
//    $_SESSION['name'] = $name;
//}


//header("Location: http://$host$uri/$extra/$jsonlogin");
?>
