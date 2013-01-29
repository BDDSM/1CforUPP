
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiObmenaSSajjtom")]
	[Route("/Catalogs/NastrojjkiObmenaSSajjtom/{Code}")]
	public class NastrojjkiObmenaSSajjtomRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<NastrojjkiObmenaSSajjtomRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiObmenaSSajjtomResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiObmenaSSajjtoms")]
	[Route("/Catalogs/NastrojjkiObmenaSSajjtoms/{Codes}")]
	public class NastrojjkiObmenaSSajjtomsRequest/*����������������������������*/: IReturn<List<NastrojjkiObmenaSSajjtomRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiObmenaSSajjtomsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiObmenaSSajjtomsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiObmenaSSajjtomService /*����������������������������*/ : Service
	{
		public object Any(NastrojjkiObmenaSSajjtomRequest request)
		{
			return new NastrojjkiObmenaSSajjtomResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiObmenaSSajjtomRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiObmenaSSajjtomResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiObmenaSSajjtomsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
