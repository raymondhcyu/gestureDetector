# -*- coding: utf-8 -*-
"""
Created on Mon Sep 16 08:42:00 2019

@author: Safet
"""

# %matplotlib inline
from scipy.fftpack import fft
from scipy import signal
import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import matplotlib.patches as patches
import seaborn as sns
import time
import datetime
import sys

# inputdata is list of x-y values

def applyFFT(dataList):

#    sns.set_style("whitegrid")
#    amplitudeCutoff = 2
#    frequencyCutoff = 15
    
    Fs = 200 # sampling frequency
    T = 1 / Fs # sampling period
    x = np.arange(0, 1, T)
    f = 15 # frequency
    
#    noise = [num + float(np.random.rand(1)) for num in np.zeros(len(x))] # create noise
    
    # y = 5 * np.sin(np.pi * x * f) + 4 * np.cos(2 * x * f + np.pi / 3) + noise # f is frequency scale factor, inject noise
#    y = np.sin(2 * np.pi * x * f) + noise
    
    y = dataList
    
#    figure, axes = plt.subplots(2, 1)
#    figure.subplots_adjust(wspace = 0.5, hspace = .5)
#    
#    sns.lineplot(x, y, ax = axes[0])
#    
#    axes[0].set_title('Trigonometric Graph')
#    axes[0].set_xlabel('x-axis')
#    axes[0].set_ylabel('y-axis')
#    
#    axes[1].set_title('FFT')
#    axes[1].set_xlabel('Frequency')
#    axes[1].set_xticks(np.arange(0, Fs / 2 * 1.1, Fs / 40))
#    axes[1].set_ylabel('Amplitude')
#    axes[1].set_yticks(np.arange(0, amplitudeCutoff + 2 * np.floor_divide(np.amax(y), 1) / 4, np.floor_divide(np.amax(y), 1) / 4)) # oor divide to find nice intervals
#    
#    goodArea = patches.Rectangle((frequencyCutoff, 0), Fs / 2 - frequencyCutoff, amplitudeCutoff, color = 'g', alpha = 0.125)
#    axes[1].add_patch(goodArea)
    
    # axes[1].axvspan(20, Fs / 2, facecolor = 'g', alpha = 0.125) # frequency cutoff
    # axes[1].axhspan(0, amplitudeCutoff, facecolor = 'y', alpha = 0.125) # amplitude cutoff
    
#    axes[0].figure.set_size_inches(15, 9) # setting single figure size changes all
    
    ffty = 2 / Fs * np.absolute(fft(signal.detrend(y))[0 : Fs // 2]) 
    # detrend to compensate for uncorrected DC bias
    # halve fft since only interested in sample frequency / 2. // = floor integer division
    # normalize 2 / Fs to match amplitude
    
    fftx = x[0 : Fs // 2] * Fs
    # halve x since only interested in sample frequency / 2. // = floor integer division
    # multiply by Fs to scale
    
    # Find frequency and amplitude cutoffs
    fftydf = pd.DataFrame(ffty) # create df
    fftxdf = pd.DataFrame(fftx) # create df
    fftdf = pd.concat([fftxdf, fftydf], axis = 1) # join both
    fftdf.columns = ['Frequency', 'Amplitude'] # name columns
    
#    print(fftdf)
    
    return fftdf
    
#    sns.lineplot(fftx, ffty, ax = axes[1])
    
#if __name__ == "__main__":
#    y = [0] * 100
#    applyFFT(y)