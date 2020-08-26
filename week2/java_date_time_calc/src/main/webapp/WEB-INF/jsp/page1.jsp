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
<form action="page1" method="get">
Date 1:
<br>
day:
<select name="date1" >
<c:forEach var="j" begin="1" end="31">
<option value="${j}">${j}</option>
</c:forEach>

</select>
month:
<select name="month1" >
<c:forEach var="j" begin="1" end="12">
<option value="${j}">${j}</option>
</c:forEach>

</select>
yr:
<select name="year1" >
<c:forEach var="j" begin="1900" end="2020">
<option value="${j}">${j}</option>
</c:forEach>

</select>
</select>
hr:
<select name="hr1" >
<c:forEach var="j" begin="0" end="60">
<option value="${j}">${j}</option>
</c:forEach>

</select>
min:
<select name="min1" >
<c:forEach var="j" begin="0" end="59">
<option value="${j}">${j}</option>
</c:forEach>

</select>
sec:
<select name="sec1" >
<c:forEach var="j" begin="0" end="59">
<option value="${j}">${j}</option>
</c:forEach>

</select>
<br>
<br>
Date 2:
<br>
day:
<select name="date2" >
<c:forEach var="j" begin="1" end="31">
<option value="${j}">${j}</option>
</c:forEach>

</select>
month:
<select name="month2" >
<c:forEach var="j" begin="1" end="12">
<option value="${j}">${j}</option>
</c:forEach>

</select>
yr:
<select name="year2" >
<c:forEach var="j" begin="1900" end="2020">
<option value="${j}">${j}</option>
</c:forEach>

</select>
hr:
</select>
<select name="hr2" >
<c:forEach var="j" begin="00" end="23">
<option value="${j}">${j}</option>
</c:forEach>

</select>

min:
</select>
<select name="min2" >
<c:forEach var="j" begin="0" end="59">
<option value="${j}">${j}</option>
</c:forEach>

</select>

sec:
</select>
<select name="sec2" >
<c:forEach var="j" begin="0" end="59">
<option value="${j}">${j}</option>
</c:forEach>

</select>
<br><br>
<select name="operation" >

<option value="1">Add</option>
<option value="2">Sub</option>


</select>
<button type="submit">Submit</button>
</form>
<br>
<p>${ans}</p>

</body>
</html>
