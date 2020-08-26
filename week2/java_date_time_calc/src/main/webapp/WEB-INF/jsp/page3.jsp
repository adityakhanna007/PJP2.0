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
<form action="page3" method="get">
Date :
<br>
day:
<select name="date" >
<c:forEach var="j" begin="1" end="31">
<option value="${j}">${j}</option>
</c:forEach>

</select>
month:
<select name="month" >
<c:forEach var="j" begin="1" end="12">
<option value="${j}">${j}</option>
</c:forEach>

</select>
yr:
<select name="year" >
<c:forEach var="j" begin="1900" end="2020">
<option value="${j}">${j}</option>
</c:forEach>

</select>
</select>
hr:
<select name="hr" >
<c:forEach var="j" begin="0" end="60">
<option value="${j}">${j}</option>
</c:forEach>

</select>
min:
<select name="min" >
<c:forEach var="j" begin="0" end="59">
<option value="${j}">${j}</option>
</c:forEach>

</select>
sec:
<select name="sec" >
<c:forEach var="j" begin="0" end="59">
<option value="${j}">${j}</option>
</c:forEach>
</select>
<br><br>


<br><br>

<button type="submit">find</button>
</form>
<br>
<p>${ans}</p>

</body>
</html>
