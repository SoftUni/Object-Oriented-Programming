<?php
  $arr = array(
    "lang" => "PHP", 
	"point" => array("x" => 20, "y" => 50), 
	"arr" => array(1.5, 3)
  );
  $arrCloned = $arr;
  
  $arrCloned["point"]["x"] = 999;
  var_dump($arr);
?>
