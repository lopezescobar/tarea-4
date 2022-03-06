Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (ComboBox1.SelectedIndex > -1) Then
            habitacion(posicion) = ComboBox1.Text
        Else
            MsgBox("ERROR, NO SELECCIONÓ HABITACION")
            ComboBox1.Focus()
            Exit Sub
        End If




        If (RadioButton1.Checked = True) Then
            privada = encamamiento * 350
        ElseIf (RadioButton2.Checked) Then
            semiprivada = encamamiento * 250

        ElseIf (RadioButton3.Checked) Then
            no_privada = encamamiento * 150

        ElseIf (RadioButton1.Checked) Then
            privada = operacion * 550

        ElseIf (RadioButton2.Checked) Then
            semiprivada = operacion * 400

        ElseIf (RadioButton3.Checked) Then
            no_privada = operacion * 300

        ElseIf (RadioButton1.Checked) Then
            privada = maternidad * 450

        ElseIf (RadioButton2.Checked) Then
            semiprivada = maternidad * 350

        ElseIf (RadioButton3.Checked) Then
            no_privada = maternidad * 250


        Else
            MsgBox("ERROR, NO SELECCIONÓ OPCION", vbExclamation, "ADVERTENCIA")
            Exit Sub
        End If

        If (CheckBox1.Checked) Or (CheckBox2.Checked) Or (CheckBox3.Checked) Then

            If (CheckBox1.Checked) Then
                privada = encamamiento * 350
            Else
                encamamiento = 0
            End If


            If (CheckBox2.Checked) Then
                semiprivada = operacion * 250
            Else
                operacion = 0
            End If

            If (CheckBox3.Checked) Then
                no_privada = maternidad * 150
            Else
                maternidad = 0
            End If
        Else
        End If

        If index < 6 Then
            pago(index) = 500
            descuento(index) = pago(index) * 0.05 * (-1)
            recargo(index) = pago(index) * 0.1
            total(index) = pago(index) + descuento(index) + recargo(index)


            ListBox1.Items.Add(pago(index))
            ListBox2.Items.Add(descuento(index))
            ListBox3.Items.Add(recargo(index))
            ListBox4.Items.Add(pago(index))
            ListBox5.Items.Add(descuento(index))
            ListBox6.Items.Add(recargo(index))
            ListBox7.Items.Add(pago(index))
            ListBox8.Items.Add(descuento(index))
            ListBox9.Items.Add(recargo(index))
            ListBox10.Items.Add(recargo(index))
            DataGridView1.Rows.Add(paciente(index), nit(index), dias_hosp(index), honorarios(index), habitacion(index), Servicio(index), pago(index), descuento(index), recargo(index), total(index))
            index = index + 1

        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub
End Class
