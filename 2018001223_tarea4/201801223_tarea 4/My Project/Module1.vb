Module Module1
    Public index = 0
    'Vectores de entrada
    Public posicion As Byte = 0
    Public privada As String
    Public semiprivada As String
    Public no_privada As String
    Public encamamiento As String
    Public operacion As String
    Public maternidad As String
    Public paciente(5)
    Public nit(5)
    Public dias_hosp(5)
    Public honorarios(5)
    Public habitacion(5)
    Public Servicio(5)
    Public Const cheque = 0.015
    Public Const targeta_debito = 0.08
    Public Const targeta_credito = 0.05


    'Vectores para el calculo
    Public pago(5) As Double
    Public descuento(5) As Double
    Public recargo(5) As Double
    Public total(5) As Double







    Sub limpiar_vectores()
        ReDim pago(5)
        ReDim descuento(5)
        ReDim recargo(5)

        index = 0
    End Sub

    Sub limpiar_entradas()
        limpiar_vectores()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
        Form1.ListBox10.Items.Clear()
        Form1.DataGridView1.Rows.Clear()

        index = 0
    End Sub

    Sub limpiar_vectores2()

        For contador = 0 To index - 1
            pago(contador) = Nothing
            descuento(contador) = Nothing
            recargo(contador) = Nothing
        Next

        index = 0
    End Sub
End Module
