<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <style>
          table {
          border-collapse: collapse;
          width: 100%;
          }

          th, td {
          text-align: left;
          padding: 8px;
          }

          tr:nth-child(even){background-color: #f2f2f2}

          th {
          background-color: #20b2aa;
          color: white;
          }
        </style>
      </head>
      <body>          
        <xsl:for-each select="Nutricion/Clinica">
          <h3>
            <xsl:value-of select="./@Nombre"/>
          </h3>
          <table>
            <tr>
              <th>Nombre</th>
              <th>Género</th>
              <th>I.M.C.</th>
              <th>I.C.A.</th>
              <th>I.M.B.</th>
              <th>Dieta</th>
              <th>Detalle Dieta</th>
            </tr>
            <xsl:for-each select="./Paciente">
              <tr>
                <td>
                  <xsl:value-of select="./@Nombre"/>
                </td>
                <td>
                  <xsl:value-of select="./@Genero"/>
                </td>
                <td>
                  <xsl:value-of select="./IndiceMasaCorporal"/>
                </td>
                <td>
                  <xsl:value-of select="./IndiceCircunferenciaAltura"/>
                </td>
                <td>
                  <xsl:value-of select="./IndiceMetabolicoBasal"/>
                </td>
                <td>
                  <xsl:value-of select="./Dieta/@Clase"/>
                </td>
                <td>
                  <xsl:for-each select="./Dieta/Alimento">
                    <xsl:value-of select="."/>
                    <xsl:if test="position() != last()">
                      <xsl:text>, </xsl:text>
                    </xsl:if>
                  </xsl:for-each>
                </td>                
              </tr>
            </xsl:for-each>
          </table>
        </xsl:for-each>        
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>