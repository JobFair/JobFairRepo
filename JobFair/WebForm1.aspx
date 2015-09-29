<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JobFair.WebForm1" %>

<!DOCTYPE html>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" 
  type="text/javascript"></script> 
 $(document).ready(function () {
 $('div.tags').find('input:checkbox').live('click', function () {
                $('.results > li').hide();
                $('div.tags').find('input:checked').each(function () {
                    $('.results > li.' + $(this).attr('rel')).show();
                });
            });
        });  
<html xmlns="http://www.w3.org/1999/xhtml">
   
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="tags">
        <label>
            <input type="checkbox" rel="arts" />
            Arts
        </label>
        <label>
            <input type="checkbox" rel="computers" />
            Computers
        </label>
        <label>
            <input type="checkbox" rel="health" />
            Health
        </label>
        <label>
            <input type="checkbox" rel="video-games" />
            Video Games
        </label>
    </div>
    <ul class="results">
        <li class="arts computers">Result 1</li>
        <li class="video-games">Result 2</li>
        <li class="computers health video-games">Result 3</li>
        <li class="arts video-games">Result 4</li>
    </ul>
    </div>
    </form>
</body>
</html>
