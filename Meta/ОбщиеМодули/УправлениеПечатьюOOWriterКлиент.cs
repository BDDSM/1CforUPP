using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.�����������
{
	public partial class �����������������OOWriter������
	{
		////////////////////////////////////////////////////////////////////////////////
		// Open Office Writer - ����������� �������
		// �������� ������ �� �������� ����� � �����
		// ��������� � ������:
		// ServiceManager - ������ ��������, ������ open office
		// Desktop - ���������� Open Office (������ UNO)
		// Document - �������� (�������� �����)
		// ��� - ��� �������� ����� ("ODT")
		//
		////////////////////////////////////////////////////////////////////////////////
		// ���������� �������
		// ������������� �������� �����: ��������� COM - ������,
		// ��� ��������������� ��������.
		//

		public object �����������������������������OOWriter(/**/)
		{
			/*�������
		ServiceManager = ����� COM������("com.sun.star.ServiceManager");*/
			/*����������
		����������������������.��������������������������������������(�������������������������(), "������",
			����("ru = '������ ��� ����� � ������ ���������� (com.sun.star.ServiceManager).'") + 
			+ �������.�� + ����������������������������(������������������()),,������);*/
			/*����������������������������������(������������������());*/
			/*������������;*/
			/*�������
		Desktop = ServiceManager.CreateInstance("com.sun.star.frame.Desktop");*/
			/*����������
		����������������������.��������������������������������������(�������������������������(), "������",
			����("ru = '������ ��� ������� ������� Desktop (com.sun.star.frame.Desktop).'") + 
			+ �������.�� + ����������������������������(������������������()),,������);*/
			/*����������������������������������(������������������());*/
			/*������������;*/
			/*��������� = ��������ComSafeArray();*/
			/*#���� �� ��������� �����
	���������.SetValue(0, ����������������(ServiceManager, "Hidden", ������));*/
			/*#���������
	
	Document = Desktop.LoadComponentFromURL("private:factory/swriter", "_blank", 0, ���������);*/
			/*#���� ��������� �����
	Document.getCurrentController().getFrame().getContainerWindow().setVisible(����);*/
			/*// �������������� ������ �� �����
*/
			/*Handler = ����� ���������("ServiceManager,Desktop,Document,���");*/
			/*Handler.ServiceManager = ServiceManager;*/
			/*Handler.Desktop = Desktop;*/
			/*Handler.Document = Document;*/
			return null;
		}
		// ���������� ��������� � ������� �������� �����
		//
		// ���������:
		// �������������������� - �������������� - �������� ������ ������
		// ������������ ��������:
		// ��������� - ������ �����
		//

		public object �������������OOWriter(/*���� ���������������������, ������������������*/)
		{
			/*Handler = ����� ���������("ServiceManager,Desktop,Document,��������");*/
			/*�������
		ServiceManager = ����� COM������("com.sun.star.ServiceManager");*/
			/*����������
		����������������������.��������������������������������������(�������������������������(), "������",
			����("ru = '������ ��� ����� � ������ ���������� (com.sun.star.ServiceManager).'") + 
			+ �������.�� + ����������������������������(������������������()),,������);*/
			/*����������������������������������(������������������());*/
			/*������������;*/
			/*�������
		Desktop = ServiceManager.CreateInstance("com.sun.star.frame.Desktop");*/
			/*����������
		����������������������.��������������������������������������(�������������������������(), "������",
			����("ru = '������ ��� ������� ������� Desktop (com.sun.star.frame.Desktop).'") + 
			+ �������.�� + ����������������������������(������������������()),,������);*/
			/*����������������������������������(������������������());*/
			/*������������;*/
			/*#���� �� ��������� �����
	������������������ = ��������������������������("ODT");*/
			/*���������������������.��������(������������������);*/
			/*#���������
	
	��������� = ��������ComSafeArray();*/
			/*#���� �� ��������� �����
	���������.SetValue(0, ����������������(ServiceManager, "Hidden", ������));*/
			/*#���������
	
	Document = Desktop.LoadComponentFromURL("file:///" + ������������������, "_blank", 0, ���������);*/
			/*#���� ��������� �����
	Document.getCurrentController().getFrame().getContainerWindow().setVisible(����);*/
			/*// �������������� ������ �� �����
*/
			/*Handler.ServiceManager = ServiceManager;*/
			/*Handler.Desktop = Desktop;*/
			/*Handler.Document = Document;*/
			/*Handler.�������� = ������������������;*/
			return null;
		}
		// ��������� ����� �������� ����� � �������� ������ �� COM ������
		//

		public object �����������������(/*Handler, ���� �����������������*/)
		{
			if(true/*�����������������*/)
			{
				/*Handler.Document.Close(0);*/
			}
			/*Handler.Document = ������������;*/
			/*Handler.Desktop = ������������;*/
			/*Handler.ServiceManager = ������������;*/
			/*ScriptControl = ������������;*/
			if(true/*Handler.��������("��������")*/)
			{
				/*������������(Handler.��������);*/
			}
			/*Handler = ������������;*/
			return null;
		}
		// ������������� �������� ��������� � ���������� OO Writer
		// Handler - ������ �� �������� �����
		//

		public void ����������������OOWriter(/*���� Handler*/)
		{
			/*ContainerWindow = Handler.Document.getCurrentController().getFrame().getContainerWindow();*/
			/*ContainerWindow.setVisible(������);*/
			/*ContainerWindow.setFocus();*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// ���� ������� ��� ������ � �������
		// �������� ������� �� ������.
		// ���������
		// Handler - ������ �� �����
		// ���������� - ��� ������� � ������
		// �������������� - �������� ������������ ������ �������
		//					�������� �� ���������: 1 - �������� ��� ������� ������� ��� �������
		//					�������� ������, �� ����������� ������� �������� �������
		// ����������������� - �������� ������������ ��������� �������,
		//					�������� �� ���������: -11 - �������� ��� ������� ������� ��� �������
		//					�������� ������, ����� ����������� ������� �������� �������
		//

		public object ���������������������(/*���� Handler, ���� ����������*/)
		{
			/*��������� = ����� ���������("Document,Start,End");*/
			/*���������.Start = ����������������������������(Handler.Document, ����������);*/
			/*���������.End   = �������������������������������(Handler.Document, ����������);*/
			/*���������.Document = Handler.Document;*/
			return null;
		}
		// �������� ������� �������� �����������
		//

		public object ����������������������������������(/*���� �����������*/)
		{
			return null;
		}
		// �������� ������� ������� �����������
		//

		public object ���������������������������������(/*�����������*/)
		{
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ���� ������� ��� ������ � �������� ������
		// ��������� ������ �� ��������� ������
		// ���������
		// Handler - ������ �� �������� MS Word � ������� ��������� �������� ������
		//

		public void ���������������������������(/*���� Handler*/)
		{
			/*oText = Handler.Document.getText();*/
			/*oCursor = oText.createTextCursor();*/
			/*oCursor.gotoEnd(False);*/
			/*oText.insertControlCharacter(oCursor, 0, False);*/
		}
		// ��������� ������� ���������� � �������� �����
		//

		public void �������������������������(/*���� �������������,
									���� �������*/)
		{
			/*�����_oTxtCrsr = �������������������������������������������(�������);*/
			while(true/*�����_oTxtCrsr.goRight(1, ������)*/)
			{
			}
			/*;
	TransferableObject = �������.Document.getCurrentController().Frame.controller.getTransferable();*/
			/*�������������������������������������������(�������������);*/
			/*�������������.Document.getCurrentController().insertTransferable(TransferableObject);*/
		}
		// ��������� ������ ���������� � �������� �����
		//

		public void ������������������������(/*���� �������������,
									���� �������*/)
		{
			/*�����_oTxtCrsr = ������������������������������������������(�������);*/
			while(true/*�����_oTxtCrsr.goRight(1, ������)*/)
			{
			}
			/*;
	TransferableObject = �������.Document.getCurrentController().Frame.controller.getTransferable();*/
			/*������������������������������������������(�������������);*/
			/*�������������.Document.getCurrentController().insertTransferable(TransferableObject);*/
		}
		// ��������� ������� � �������� ����� �� ������, ��� ���� �������
		// ��������� � ������� ���������� �� ������ �������.
		// ����������� ��� ��������� ������ �������.
		//
		// ���������
		// ������������� - ������ �� �������� �����
		// �������Handler - ������ �� ������� � ������.
		// ������������������� - ������, ��������� �� ��������� ������ ����� ������ �������
		//
		// ������������ ��������:
		// �����������������
		//

		public void �������������������(/*���� �������������Handler,
							���� �������Handler,
							���� ������������������� = ������,
							���� ������������������������� = ����*/)
		{
			/*�����_oTxtCrsr = �������Handler.Document.getCurrentController().getViewCursor();*/
			/*�����_oTxtCrsr.gotoRange(�������Handler.Start, ����);*/
			if(true/*�� �������������������������*/)
			{
				/*�����_oTxtCrsr.goRight(1, ����);*/
			}
			/*�����_oTxtCrsr.gotoRange(�������Handler.End, ������);*/
			/*TransferableObject = �������Handler.Document.getCurrentController().Frame.controller.getTransferable();*/
			/*�������������Handler.Document.getCurrentController().insertTransferable(TransferableObject);*/
			if(true/*�������������������������*/)
			{
				/*�������������(�������������Handler);*/
			}
			if(true/*�������������������*/)
			{
				/*���������������������������(�������������Handler);*/
			}
		}
		// ��������� ��������� � ��������� ���� �������� �����
		//

		public void ������������������(/*�������������, ������*/)
		{
		}
		// ��������� ������� ��������� � �������� �����
		//

		public void �������������������������������(/*���� �������������Handler,
										  ���� �������Handler,
										  ���� ������,
										  ���� ���������������� = ����,
										  ���� ������������������� = ������*/)
		{
			/*�����_oTxtCrsr = �������Handler.Document.getCurrentController().getViewCursor();*/
			/*�����_oTxtCrsr.gotoRange(�������Handler.Start, ����);*/
			if(true/*�� ����������������*/)
			{
				/*�����_oTxtCrsr.goRight(1, ����);*/
			}
			/*�����_oTxtCrsr.gotoRange(�������Handler.End, ������);*/
			/*TransferableObject = �������Handler.Document.getCurrentController().Frame.controller.getTransferable();*/
			if(true/*�������������������*/)
			{
				/*���������������������������(�������������Handler);*/
			}
		}
		// ������������� ������ � ����� ��������� ��������������
		//

		public void ���������������������������������������(/*���� ��������������*/)
		{
			/*oDoc = ��������������.Document;*/
			/*oViewCursor = oDoc.getCurrentController().getViewCursor();*/
			/*oTextCursor = oDoc.Text.createTextCursor();*/
			/*oViewCursor.gotoRange(oTextCursor, ����);*/
			/*oViewCursor.gotoEnd(����);*/
		}
		// ������������� ������ �� ������� ����������
		//

		public object �������������������������������������������(/*���� ��������������*/)
		{
			/*xCursor = ��������������.Document.getCurrentController().getViewCursor();*/
			/*PageStyleName = xCursor.getPropertyValue("PageStyleName");*/
			/*oPStyle = ��������������.Document.getStyleFamilies().getByName("PageStyles").getByName(PageStyleName);*/
			/*oPStyle.HeaderIsOn = ������;*/
			/*HeaderTextCursor = oPStyle.getPropertyValue("HeaderText").createTextCursor();*/
			/*xCursor.gotoRange(HeaderTextCursor, ����);*/
			return null;
		}
		// ������������� ������ �� ������ ����������
		//

		public object ������������������������������������������(/*���� ��������������*/)
		{
			/*xCursor = ��������������.Document.getCurrentController().getViewCursor();*/
			/*PageStyleName = xCursor.getPropertyValue("PageStyleName");*/
			/*oPStyle = ��������������.Document.getStyleFamilies().getByName("PageStyles").getByName(PageStyleName);*/
			/*oPStyle.FooterIsOn = ������;*/
			/*FooterTextCursor = oPStyle.getPropertyValue("FooterText").createTextCursor();*/
			/*xCursor.gotoRange(FooterTextCursor, ����);*/
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ��������� �������
		// �������� ����������� ���������, ����� ������� �������� UNO ���������������
		// ���������.
		//

		public object ����������������(/*���� ServiceManager, ���� ��������, ���� ��������*/)
		{
			/*PropertyValue = ServiceManager.Bridge_GetStruct("com.sun.star.beans.PropertyValue");*/
			/*PropertyValue.Name = ��������;*/
			/*PropertyValue.Value = ��������;*/
			return null;
		}

		public object ����������������������������(/*���� xDocument, ���� ����������*/)
		{
			/*�������������� = "{v8 �������." + ���������� + "}";*/
			/*xSearchDescr = xDocument.createSearchDescriptor();*/
			/*xSearchDescr.SearchString = ��������������;*/
			/*xSearchDescr.SearchCaseSensitive = ����;*/
			/*xSearchDescr.SearchWords = ������;*/
			/*xFound = xDocument.findFirst(xSearchDescr);*/
			if(true/*xFound = ������������*/)
			{
				/*����������������� ����("ru = '�� ������� ������ ������� ������:'") + " " + ����������;*/
			}
			return null;
		}

		public object �������������������������������(/*���� xDocument, ���� ����������*/)
		{
			/*�������������� = "{/v8 �������." + ���������� + "}";*/
			/*xSearchDescr = xDocument.createSearchDescriptor();*/
			/*xSearchDescr.SearchString = ��������������;*/
			/*xSearchDescr.SearchCaseSensitive = ����;*/
			/*xSearchDescr.SearchWords = ������;*/
			/*xFound = xDocument.findFirst(xSearchDescr);*/
			if(true/*xFound = ������������*/)
			{
				/*����������������� ����("ru = '�� ������ ����� ������� ������:'") + " " + ����������;*/
			}
			return null;
		}

		public void �������������(/*�������������Handler*/)
		{
			/*oFrame = �������������Handler.Document.getCurrentController().Frame;*/
			/*dispatcher = �������������Handler.ServiceManager.CreateInstance ("com.sun.star.frame.DispatchHelper");*/
			/*oViewCursor = �������������Handler.Document.getCurrentController().getViewCursor();*/
			/*dispatcher.executeDispatch(oFrame, ".uno:GoUp", "", 0, ��������ComSafeArray());*/
			while(true/*oViewCursor.TextTable <> ������������*/)
			{
				/*dispatcher.executeDispatch(oFrame, ".uno:GoUp", "", 0, ��������ComSafeArray());*/
			}
			/*;
	
	dispatcher.executeDispatch(oFrame, ".uno:Delete", "", 0, ��������ComSafeArray());*/
			while(true/*oViewCursor.TextTable <> ������������*/)
			{
				/*dispatcher.executeDispatch(oFrame, ".uno:GoDown", "", 0, ��������ComSafeArray());*/
			}
			/*;;*/
		}

		public object ��������ComSafeArray(/**/)
		{
			/*#���� ��������� �����
	scr = ����� COM������("MSScriptControl.ScriptControl");*/
			/*scr.language = "javascript";*/
			/*scr.eval("������=new Array()");*/
			/*#�����
	������� ����� COMSafeArray("VT_DISPATCH", 1);*/
			/*#���������;*/
			return null;
		}

		public object �������������������������(/**/)
		{
			return null;
		}

		public void ����������������������������������(/*������������������*/)
		{
			/*#���� ��������� �����
	�������������� = ����("ru = '��� ������ ����� ���, ��������� ������� Internet Explorer ��� ����������� ������������ ������� Windows.'");*/
			/*#�����		
	�������������� = "";*/
			/*#���������
	��������������� = ����������������������������.��������������������������(
		����("ru = '�� ������� ������������ �������� �����: %1. 
			|��� ������ �������� ���� � ������� OpenOffice.org Writer ���������, ����� �� ���������� ��� ���������� ����� OpenOffice.org. %2'"),
		��������������������������(������������������), ��������������);*/
			/*����������������� ���������������;*/
		}
	}
}

