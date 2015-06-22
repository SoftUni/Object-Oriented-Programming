<?php
  $obj = new stdClass();
  $obj->lang = "PHP";
  $obj->address = new stdClass();
  $obj->address->town = "Sofia";

  $clonedObj = clone $obj;
  $clonedObj->address->town = "Varna";
  var_dump($obj);
?>
