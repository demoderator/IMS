<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="IMS_v1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Login</title>

	<!-- Bootstrap core CSS -->
    <link href="dist/css/bootstrap.css" rel="stylesheet" />
	<link href="dist/css/carousel.css" rel="stylesheet" />
	<link href="dist/css/stylesheet.css" rel="stylesheet" />
	<!--<link href="dist/css/custom.css" rel="stylesheet">-->

   <!-- Custom styles for this template -->
    <link href="dist/css/navbar-fixed-top.css" rel="stylesheet" />
	
	<link href='http://fonts.googleapis.com/css?family=Titillium+Web:700' rel='stylesheet' type='text/css' />

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../../assets/js/html5shiv.js"></script>
      <script src="../../assets/js/respond.min.js"></script>
    <![endif]-->
	<link href="css/theme.css" rel="stylesheet" type="text/css" />
	
</head>

<body>
<form id="form1" runat="server">
	<div class="wrapper">
		<div class="top-row">
			<div class="logo">
			</div>
			<div class="clear"></div>
		</div>
		
		<div class="login-cont">
			
				<div class="_row" id="choice">
					
					<div class="col-lg-4 options-se" id="choice1" runat="server">
						
						<asp:ImageButton ID="imgbtn1" runat="server" ImageUrl="images/warehouse-in.png" OnClick="imgbtn1_Click" />
						
					</div>
					
					<div class="col-lg-4 options-se" id="choice2" runat="server">
						<asp:ImageButton ID="imgbtn2" runat="server" ImageUrl="images/store-in.png" OnClick="imgbtn2_Click" />
					</div>
					
					<div class="col-lg-4 options-se" id="choice3" runat="server">
						<asp:ImageButton ID="imgbtn3" runat="server" ImageUrl="images/hq-in.png" OnClick="imgbtn3_Click" />
					</div>
					<div class="clearfix"></div>
					
				</div>
				
				
				<div class="_row">
					<div class="login-header">Login to IMS</div>
					<div class="login-body">
						<label class="login-lab">UserName:</label><br />
						<asp:TextBox ID="txtUse" runat="server" type="text" />
						
						<label class="login-lab">Password:</label><br />
                        <asp:Panel ID="panel" runat="server" DefaultButton="btnLogin">
						<asp:TextBox ID="txtPas" runat="server"  TextMode="Password" type="text"/>
						
						<asp:Button ID="btnLogin" runat="server" CssClass="blue" Text="Log in"  OnClick="btnLogin_Click" />
                            </asp:Panel>
					
					</div>
					
				</div>
				
			
		</div>
		
	</div>
		 </form>
		<!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script type="text/javascript" src="assets/js/jquery.js"></script>
    <script type="text/javascript" src="dist/js/bootstrap.min.js"></script>
	<script type="text/javascript" src="assets/js/holder.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {

            $("#choice .options-se:nth-child(3)").css("border-right", 0);


        });
    </script>
    <
</body>
</html>
