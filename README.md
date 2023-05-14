# Pruebas

El codigo para crear el procedimiento almacenado es el siguiente 

```sql
CREATE PROCEDURE SP_MOSTRARTABLAACTIVOS
AS
SELECT * FROM Activos
GO
