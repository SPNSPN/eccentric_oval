PRJ := main

CS := mcs

LIBDIR := /usr/lib/mono/4.5
LIB := $(LIBDIR)/mscorlib.dll,$(LIBDIR)/System.Windows.Forms.dll,$(LIBDIR)/System.Drawing.dll,$(LIBDIR)/System.Data.dll

SRC := src
BLD := build

SRCS := $(wildcard $(SRC)/*.cs)

.PHONY: all run
all: $(BLD)/$(PRJ)

run: $(BLD)/$(PRJ)
	mono $<

$(BLD)/$(PRJ): $(SRCS)
	$(CS) -out:$@ -r:$(LIB) $^ 

.PHONY: clean
clean:
	rm $(BLD)/*

