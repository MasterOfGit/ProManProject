<?php
session_start();
$host  = $_SERVER['HTTP_HOST'];
$uri   = rtrim(dirname($_SERVER['PHP_SELF']), '/\\');


//für den echten Einsatz Passwörter nicht im Klartext speichern!
$benutzer = [
    'admin' => '12345',
    'manu' => '6789',
    'merlin' => 'asdfg'
];

$name = isset($_POST['userid']) ? $_POST['userid'] : '';
$passwort_aktuell = isset($_POST['pwd']) ? $_POST['pwd'] : '';

if (!array_key_exists($name, $benutzer)) {
    $extra = 'start.php?f=1';
} elseif ($benutzer[$name] != $passwort_aktuell) {
    $extra = 'start.php?f=2';

} else {
    $extra = 'usercontent.php';
    $_SESSION['login'] = 'ok';
    $_SESSION['name'] = $name;
}


header("Location: http://$host$uri/$extra");
?>
