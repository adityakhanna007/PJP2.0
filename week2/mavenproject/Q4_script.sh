
echo "======================================================="
echo "Prevent maven from downloading dependencies every time "
echo "======================================================="

mvn dependency:go-offline>Q4_output.txt
mvn clean package
$SHELL