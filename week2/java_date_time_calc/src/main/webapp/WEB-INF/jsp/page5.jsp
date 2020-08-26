<%@ page import="java.util.*" %>
<%@ page import="com.sapient.week2.java_date_time_calc.datetimePojo" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html lang="en">
<head>
  <title>Report</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
  
</head>
<style>
  
</style>
<body>
<form action="page5" method="get">
<select name="option">
<option value="1">Today</option>
<option value="2">Tomorrow</option>
<option value="3">Day-After-Tomorrow</option>
<option value="4">Yesterday</option>
<option value="5">Day-before-yesterday</option>
<option value="6">Lastweek</option>

<option value="7">NextWeek</option>
<option value="8">NextMonth</option>
<option value="9">NextYear</option>


</select>
<button type="submit">Submit</button>
</form>
<br>
<p>${ans}</p>

</body>
</html>
