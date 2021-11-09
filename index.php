<?php
  $request = $_SERVER['REQUEST_URI'];
  switch ($request){
    case '/':
      require './home.html';
      die();
    break;
    case '/home':
      require './home.html';
      die();
    case '/index.php':
      require './home.html';
      die();
    break;
    case '/about':
      require './about.html';
      die();
    break;
    default:
      http_response_code(404);
      require '404.html';
      die();
    break;
  }
?>