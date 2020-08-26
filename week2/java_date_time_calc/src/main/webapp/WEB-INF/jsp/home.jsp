<%@ page import="java.util.*" %>
<%@ page import="com.sapient.week2.java_date_time_calc.datetimePojo" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>
<c:set var="theLocale" value="${not empty param.theLocale?param.theLocale:pageConext.request.Locale }" scope="session"/>
<fmt:setLocale value="${theLocale}"/>
<fmt:setBundle basename="com.sapient.jsp.tagdemo.i18n.resources.myLabels"/>


<!DOCTYPE html>
<html >
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
<a href="home?theLocale=en_US">English (US)</a>
|
<a href="home?theLocale=es_ES">Spanish (ES)</a>
|
<a href="home?theLocale=de_DE">German (DE)</a>
<br>
<form action="choice" method="get">
<fmt:message key="label.choice"/>
<select name="choice" id="choice">
<option value="1"><fmt:message key="label.first"/></option>
<option value="2"><fmt:message key="label.second"/></option>
<option value="3"><fmt:message key="label.third"/></option>
<option value="4"><fmt:message key="label.fourth"/></option>
<option value="5"><fmt:message key="label.fifth"/></option>
</select>
<button type="submit"><fmt:message key="label.submit"/></button>
</form>

</body>
</html>
