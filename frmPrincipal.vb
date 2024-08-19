
Public Class frmPrincipal
    Public Property TipoUsuario As Integer
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True

        TipoUsuario = 1

        If TipoUsuario = 1 Then
            MessageBox.Show("Bienvenido, Representante de la FPF.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TipoUsuario = 2 Then
            MessageBox.Show("Bienvenido,Representante de la LFP.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TipoUsuario = 3 Then
            MessageBox.Show("Bienvenido,Representante del Club.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ENFRENTAMIENTO.Visible = False
            ARBITRO.Visible = False
            ESTADIO.Visible = False
            FICHA.Visible = False
            CLUB.Visible = False
            DELEGADO.Visible = False
        ElseIf TipoUsuario = 4 Then
            MessageBox.Show("Bienvenido,Administrador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TipoUsuario = 5 Then
            MessageBox.Show("Bienvenido,Coordinador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLUB.Visible = False
            JUGADOR.Visible = False
            CONTRATO.Visible = False
            SOLICITUD.Visible = False
            CERTIFICADO.Visible = False
            REPRESENTANTE.Visible = False
        ElseIf TipoUsuario = 6 Then
            MessageBox.Show("Bienvenido,Operador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TipoUsuario = 9 Then
            MessageBox.Show("Bienvenido,Representante CONAR.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLUB.Visible = False
            JUGADOR.Visible = False
            CONTRATO.Visible = False
            SOLICITUD.Visible = False
            CERTIFICADO.Visible = False
            REPRESENTANTE.Visible = False
            DELEGADO.Visible = False
            ESTADIO.Visible = False
            FICHA.Visible = False
            ENFRENTAMIENTO.Visible = False
        ElseIf TipoUsuario > 9 Or TipoUsuario < 1 Or TipoUsuario = 8 Or TipoUsuario = 7 Then
            MessageBox.Show("Bienvenido,usuario Desconocido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLUB.Visible = False
            JUGADOR.Visible = False
            CONTRATO.Visible = False
            SOLICITUD.Visible = False
            CERTIFICADO.Visible = False
            REPRESENTANTE.Visible = False
            DELEGADO.Visible = False
            ARBITRO.Visible = False
            ESTADIO.Visible = False
            FICHA.Visible = False
            ENFRENTAMIENTO.Visible = False
        End If


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ARBITRO.Click
        Dim ObjArbitro As New frmArbitro
        ObjArbitro.MdiParent = Me
        ObjArbitro.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.LayoutMdi(2)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.LayoutMdi(1)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Me.LayoutMdi(0)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles JUGADOR.Click
        Dim ObjJugador As New frmJugador
        ObjJugador.MdiParent = Me
        ObjJugador.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles SOLICITUD.Click
        Dim ObjSolicitud As New frmSolicitud
        ObjSolicitud.MdiParent = Me
        ObjSolicitud.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles CLUB.Click
        Dim ObjClub As New frmClub
        ObjClub.MdiParent = Me
        ObjClub.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ESTADIO.Click
        Dim ObjEstadio As New frmEstadio
        ObjEstadio.MdiParent = Me
        ObjEstadio.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles REPRESENTANTE.Click
        Dim ObjRepresentante As New frmRepresentante
        ObjRepresentante.MdiParent = Me
        ObjRepresentante.Show()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles CERTIFICADO.Click
        Dim ObjCertificadoM As New frmCertificadoM
        ObjCertificadoM.MdiParent = Me
        ObjCertificadoM.Show()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles FICHA.Click
        Dim ObjFichaP As New frmFichaP
        ObjFichaP.MdiParent = Me
        ObjFichaP.Show()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles CONTRATO.Click
        Dim ObjContrato As New frmContrato
        ObjContrato.MdiParent = Me
        ObjContrato.Show()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles DELEGADO.Click
        Dim ObjDelegadoP As New frmDelegadoP
        ObjDelegadoP.MdiParent = Me
        ObjDelegadoP.Show()
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ENFRENTAMIENTO.Click
        Dim ObjEnfrentamiento As New frmEnfrentamiento
        ObjEnfrentamiento.MdiParent = Me
        ObjEnfrentamiento.Show()
    End Sub
End Class