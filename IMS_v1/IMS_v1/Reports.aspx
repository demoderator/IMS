﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="IMS_DPS.Reports" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Main Page</title>
	
	<link rel="stylesheet" type="text/css" href="css/demo.css" media="screen" />
	<link rel="stylesheet" type="text/css" href="css/jquery.navgoco.css" media="screen" />
	<!-- Bootstrap core CSS -->
    <link href="dist/css/bootstrap.css" rel="stylesheet"/>
	<link href="dist/css/carousel.css" rel="stylesheet"/>
	<link href="dist/css/stylesheet.css" rel="stylesheet"/>
	<!--<link href="dist/css/custom.css" rel="stylesheet">-->

   <!-- Custom styles for this template -->
    <link href="dist/css/navbar-fixed-top.css" rel="stylesheet"/>
	
	<link href='http://fonts.googleapis.com/css?family=Titillium+Web:700' rel='stylesheet' type='text/css'/>

    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../../assets/js/html5shiv.js"></script>
      <script src="../../assets/js/respond.min.js"></script>
    <![endif]-->
	<link href="css/theme.css" rel="stylesheet" type="text/css" />
	
	
		<!--<script src="http://code.jquery.com/jquery-1.10.2.min.js"></script>-->
		<script type="text/javascript" src="assets/js/jquery.js"></script>
		<script  type="text/javascript" src="js/highlight.pack.js"></script>
		<script  type="text/javascript" src="js/demo.js"></script>

		<!-- Add JQuery cookie plugin (optional) -->
		
		<!-- Add navgoco main js and css files  -->
		<script type="text/javascript" src="js/jquery.navgoco.js"></script>
		

		<script type="text/javascript" id="demo1-javascript">
		    $(document).ready(function () {
		        // Initialize navgoco with default options
		        $("#demo1").navgoco({
		            caretHtml: '',
		            accordion: false,
		            openClass: 'open',
		            save: true,
		            cookie: {
		                name: 'navgoco',
		                expires: false,
		                path: '/'
		            },
		            slide: {
		                duration: 400,
		                easing: 'swing'
		            },
		            // Add Active class to clicked menu item
		            onClickAfter: function (e, submenu) {
		                e.preventDefault();
		                $('#demo1').find('li').removeClass('mactive');
		                var li = $(this).parent();
		                var lis = li.parents('li');
		                li.addClass('mactive');
		                lis.addClass('mactive');
		            },
		        });

		        $("#collapseAll").click(function (e) {
		            e.preventDefault();
		            $("#demo1").navgoco('toggle', false);
		        });

		        $("#expandAll").click(function (e) {
		            e.preventDefault();
		            $("#demo1").navgoco('toggle', true);
		        });
		    });
		</script>
		<script type="text/javascript" id="demo2-javascript">
		    $(document).ready(function () {
		        $("#demo2").navgoco({ accordion: true });
		    });
		</script>
	
	
</head>
<body style="background-color:#eeeff1; background-image:none;">

	<div class="wrapper">
		<div class="top-row">
			<div class="logo">
			</div>
			
			<ul class="nav navbar-nav top-user">
            <li class="dropdown">
              <a href="#" class="dropdown-toggle" data-toggle="dropdown">User ABC<b class="caret"></b></a>
              <ul class="dropdown-menu">
                <li><a href="#">Change Password</a></li>
				<li class="divider"></li>
                <a href="Login.aspx">Logout</a>
              </ul>
            </li>
          </ul>
			
			<div class="clear"></div>
		</div>
		
		
		
		<div class="right full" style="background:none;">
			
			
					
					
	 <ul id="demo1" class="nav">
	<li><a href="ReportFormat_simple.aspx">All Reports</a></li>
	<li><a href="ReportFormat_simple.aspx">Sale Reports</a>
		<ul>
			<li><a href="ReportFormat_simple.aspx">Summary Sales Daily Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx"> Daily Sales by Sales Rep</a>
					<a href="ReportFormat_simple.aspx"> Daily Sales by Store</a>
                   <a href="ReportFormat_simple.aspx"> Daily Sales by Cashier</a>
                   <a href="ReportFormat_simple.aspx"> Daily Sales by Supplier</a>
                    <a href="ReportFormat_simple.aspx"> Daily Sales by Register</a>
                    <a href="ReportFormat_simple.aspx"> Daily Sales by Category</a>
                    <a href="ReportFormat_simple.aspx"> Daily Sales by Department</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Sales Tax Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Summary Tax Collected Daily </a>
					<a href="ReportFormat_simple.aspx">Detailed Tax Collected</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx"> Sales History Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx"> Sales History</a>
					<a href="ReportFormat_simple.aspx"> Consolidated Sales</a>
                    <a href="ReportFormat_simple.aspx"> History-Slow Moving Items</a>
                    <a href="ReportFormat_simple.aspx"> Yearly Sales History - None Moving Items</a>
                    <a href="ReportFormat_simple.aspx"> Period Sales History - Open to buy</a>
                    <a href="ReportFormat_simple.aspx"> Sales by Till</a> 
				</ul>
			</li>
             <li><a href="ReportFormat_simple.aspx"> Cost/Sales Analysis Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Regional Cost/Sales</a>
					<a href="ReportFormat_simple.aspx">Store Cost/Sales</a>
                    <a href="ReportFormat_simple.aspx">Department Cost/Sales</a>  
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Other Sales Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Detailed Sales</a>
					<a href="ReportFormat_simple.aspx">Sales Summary - Network Status and Error Logs</a>
                  <a href="ReportFormat_simple.aspx">Sales by Volume - Standard Margins</a>
                    <a href="ReportFormat_simple.aspx">Returns report - Promotional Margins</a>
                   <a href="ReportFormat_simple.aspx">Sales by Value - Fast Moving Items</a>
                   <a href="ReportFormat_simple.aspx">Sales by assistant - Daily Customer listing</a>
				</ul>
			</li>
		</ul>
	</li>
            <li><a href="ReportFormat_simple.aspx">Inventory Reports</a>
		<ul>
			<li><a href="ReportFormat_simple.aspx">Inventory Analysis Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Inventory Product Alert Report</a>
					<a href="ReportFormat_simple.aspx">Inventory Department wise</a>
                 <a href="ReportFormat_simple.aspx">Inventory Category Wise</a>
                   <a href="ReportFormat_simple.aspx">Inventory Sub Category Wise</a>
                   <a href="ReportFormat_simple.aspx">Inventory Vendor wise</a>
                   <a href="ReportFormat_simple.aspx">Near to expire Inventory</a>
                    <a href="ReportFormat_simple.aspx">inventory consumption by store</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Trending & Profit  Analysis Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Inventory with highest trend </a>
					<a href="ReportFormat_simple.aspx">inventory with lowest trend</a>
                   <a href="ReportFormat_simple.aspx">inventory giving greater Profit</a>
					<a href="ReportFormat_simple.aspx">inventory which cost most</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Head Office Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Inventory Count - Head Office</a>
				<a href="ReportFormat_simple.aspx">Inventory Count Variance - Head Office</a>
				</ul>
			</li>
             <li><a href="ReportFormat_simple.aspx">Other Inventory Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Inventory adjustments - Account Balances </a>
					<a href="ReportFormat_simple.aspx">Random Inventory Count Check list - Account Transactions</a>
                   <a href="ReportFormat_simple.aspx">Inventory Movements History - Daily Transaction Log / Summary</a> 
                   <a href="ReportFormat_simple.aspx">Inventory Ledger - Quantity Audit </a>
					<a href="ReportFormat_simple.aspx">Product Inventory - Inventory Valuation </a>
                   <a href="ReportFormat_simple.aspx">Inventory Allocation</a> 
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Inventory Master Listing Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Master Price List</a>
					<a href="ReportFormat_simple.aspx">Master Quantity List </a>
                    <a href="ReportFormat_simple.aspx">Master Value List</a>
				</ul>
			</li>
             <li><a href="ReportFormat_simple.aspx">Inventory Store Listing Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Snapshot Store Price List</a>
					<a href="ReportFormat_simple.aspx">Snapshot Store Quantity List</a>
                    <a href="ReportFormat_simple.aspx">Quantity Discrepancy List </a>
				</ul>
			</li>
             <li><a href="ReportFormat_simple.aspx">Other Inventory Listing Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Supplier List</a>
					<a href="ReportFormat_simple.aspx">Alias List</a>
                   <a href="ReportFormat_simple.aspx">Substitute List</a>
                   <a href="ReportFormat_simple.aspx">Serial Number List</a>
					<a href="ReportFormat_simple.aspx">Item Movement</a>
                    <a href="ReportFormat_simple.aspx">Offline Inventory List</a>
                    <a href="ReportFormat_simple.aspx">Trending Products List</a>
				</ul>
			</li>
		</ul>
	</li>

               <li><a href="ReportFormat_simple.aspx">Order Reports</a>
		<ul>
			<li><a href="ReportFormat_simple.aspx">Quotes & BackOrder  Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Backorders—Summary</a>
				<a href="ReportFormat_simple.aspx">Backorders—Detailed</a>
                   <a href="ReportFormat_simple.aspx">Quotes—Summary</a>
                 <a href="ReportFormat_simple.aspx">Quotes—Detailed</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Purchase & Sales Order Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Sales orders </a>
					<a href="ReportFormat_simple.aspx">Purchase orders</a>
                    <a href="ReportFormat_simple.aspx">Purchase Orders - Value Audit</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Sales History Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Sales History</a>
					<a href="ReportFormat_simple.aspx">Consolidated Sales History-Slow Moving Items</a>
                    <a href="ReportFormat_simple.aspx">Yearly Sales History - None Moving Items</a>
					<a href="ReportFormat_simple.aspx">Period Sales History - Open to buy</a>
                   <a href="ReportFormat_simple.aspx">Sales by Till</a>
				</ul>
			</li>
             <li><a href="ReportFormat_simple.aspx">Inventory Order Reprots</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Inventory Transfer In</a>
					<a href="ReportFormat_simple.aspx">Suggested Orders - Excess Inventory</a>
				</ul>
			</li>
            <li><a href="ReportFormat_simple.aspx">Dispatch Order Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Goods Received Note - Suggested Dispatch Orders </a>
                    <a href="ReportFormat_simple.aspx">Goods on Order - Dispatch Orders  </a>
                  <a href="ReportFormat_simple.aspx">Dispatch Orders - Classification Totals E.G. Department totals  </a>
				</ul>
			</li>
             <li><a href="ReportFormat_simple.aspx">Other Order Reports</a>
				<ul>
					<a href="ReportFormat_simple.aspx">Work orders</a>
					<a href="ReportFormat_simple.aspx">Margin Report</a>
                 <a href="ReportFormat_simple.aspx">Back Order Report - Best Customer report</a>
                    <a href="ReportFormat_simple.aspx">Branch Orders - Head Office </a>
				</ul>
			</li>
            
		</ul>
	</li>

     <li><a href="ReportFormat_simple.aspx">Store Specific Reports</a>
		<ul>
			
                <a href="ReportFormat_simple.aspx">Branch Performance Report - Price Override report</a>
           <a href="ReportFormat_simple.aspx">Picking list - Branch Goods Received / Dispatch Report</a>
          <a href="ReportFormat_simple.aspx">Branch Product Change Report</a>
         <a href="ReportFormat_simple.aspx">Branch Promotional Price Report</a>
         <a href="ReportFormat_simple.aspx">Branch Inventory Change Report</a>
         <a href="ReportFormat_simple.aspx">Branch Price Change Report</a>
		</ul>
	</li>
            
 <li><a href="ReportFormat_simple.aspx">Top Performers Reports</a>
		<ul>
			<a href="ReportFormat_simple.aspx">Top Sales Reps</a>
          <a href="ReportFormat_simple.aspx">Top Customers</a>
          <a href="ReportFormat_simple.aspx">Top Cashiers</a>
        <a href="ReportFormat_simple.aspx">Top Suppliers</a>
          <a href="ReportFormat_simple.aspx">Top Items</a>
        <a href="ReportFormat_simple.aspx">Top Departments</a>
         <a href="ReportFormat_simple.aspx">Top Categories</a>
		</ul>
	</li>

 <li><a href="ReportFormat_simple.aspx">Other Reports</a>
		<ul>
			<a href="ReportFormat_simple.aspx">Loyalty Scheme Report</a>
           <a href="ReportFormat_simple.aspx">Overstock reports based upon weeks covered required</a>
            <a href="ReportFormat_simple.aspx">Suggested Replenishment base upon sales history</a>
            <a href="ReportFormat_simple.aspx">Random Inventory Count Variance - Cash Reconciliation </a>
            <a href="ReportFormat_simple.aspx">Aged Inventory - Currency Change Report </a> 
		</ul>
	</li>	
	
</ul>

	
		<br />
        <br />
        <br />
          &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp; 
             &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;  &nbsp;&nbsp;&nbsp;   <a href="HeadOfficeMain.aspx" class="blue">Go Back</a>
       
			
			
			
			
		</div>
		
	
		
	</div>
		
	<!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    
    <script  type="text/javascript" src="dist/js/bootstrap.min.js"></script>
	<script  type="text/javascript" src="assets/js/holder.js"></script>
	
	<script  type="text/javascript">
	    $(document).ready(function (e) {




	        $('input:checkbox').click(function () {
	            if ($(this).is(':checked')) {
	                $(this).closest('tr').addClass('highlighted');
	            }
	            else {
	                // Stuff to do every *even* time the element is clicked;
	                $(this).closest('tr').removeClass('highlighted');
	            }
	        });


	        $(document).on('click change', 'input[name="check_all"]', function () {
	            var checkboxes = $('.tr-check');
	            if ($(this).is(':checked')) {
	                checkboxes.attr("checked", true);
	                checkboxes.closest('tr').addClass('highlighted');
	            } else {
	                checkboxes.attr("checked", false);
	                checkboxes.closest('tr').removeClass('highlighted');
	            }
	        });

	    });




	</script>
	
</body>
</html>
